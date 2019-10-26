---
 layout: post
 title: "Concurrency-Parallelism-and beyond"
 date: 2017-08-19
 author: Bhavishya
 category: Concurrency
 tags:
 - Concurrency
 - Parallelism
 - Python
---

# Concurrency…Parallelism…and Eventual world Domination;) …

NOTE: “Bugs(typos?) are always there, it’s for you to find”…Same goes for this
article.

#### So what’s in-store?

What I hope with this article is,“Ideally” it should be a primer for people
starting from almost zero knowledge(or more quantitatively no practical coding
experience implementing concurrency) to get a sufficient feel for what it is and
from there on they might explore more at their own discretion…

The structure would be to give away the theory first followed by some code-
walks seeing concurrency live in action across different scenarios and
paradigms…

So let’s dive in…

#### **CONCURRENCY VS PARALLELISM ?**

> *“Concurrency is about dealing with lots of things at once. Parallelism is about
> doing lots of things at once.” — Rob Pike*

Remember “**Concurrency:Sequential :: Parallel:serial”.**

So Finally once again straight from Wikipedia:

> “It is possible to have parallelism without concurrency (such as bit-level
> parallelism), and concurrency without parallelism (such as multitasking by
time-sharing on a single-core CPU).”

Concurrency and Parallelism are both independent phenomena…So a quick QUIZ:

Imagine we go down 20 yrs back into history…the MULTI-CORE magic hasn’t happened
yet…and we all have single core computers…what does that mean?

It means no “parallel computing”. But still, the CPU(I’d say kernel maybe) does
processes concurrently(Oh yes, remember multitasking).

#### HISTORY?

So it all began with **E.W. Dijkstra[1] (remember Shortest Path algorithm)** in
The 1960s and then there was **Tony Hoare**(yes the guy who came up with
“QUICKSORT”) who invented
[CSP](https://www.wikiwand.com/en/Communicating_sequential_processes) and
then came **Erlang(the language used by WHATSAPP’s backend**) and much later(in
last decade)** Elixir and Clojure(**[DISCORD](https://discordapp.com/)** if you
know is written in Elixir)**…But the true reason of the recent buzz(and somewhat
inspiration for this post too) is [golang](https://golang.org/){This is a
relatively new language straight from google which has brought CONCURRENCY to
forefront again by providing some *cool constructs that make doing concurrency
easier*…You could well do it in any other language but it would difficult(as in
“*cry yourself* *to sleep” *difficult )}.

SIDE-NOTE: For people who are aware of Functional
Programming(Erlang, Elixir, Clojure all are functional) might have heard that
**concurrency is easier to do in functional languages**…that is because of
**immutability of objects**( the …fundamental feature of FP)…And one basic problem
with concurrency is of simultaneous changing **of an object’s state(**[race
conditions](https://stackoverflow.com/questions/34510/what-is-a-race-condition)**)**…So
simply put "no(less) change -> easier concurrency".(This is an oversimplified
explanation.)

Here’s a fun comparison, that displays the ease of doing concurrency in different
languages…

![Plot](https://github.com/bhavishyagopesh/pclub.in/blob/concurrency-article/assets/image/concurrency-article.png)

> Hey don’t get scared of the last paragraph it’s just to convince you that
> CONCURRENCY ITSELF IS A CONCEPT AND COULD BE DONE IN MANY LANGUAGES WITH VARYING
EASE(OR PAIN)…it’s perfectly fine if you just remember the last line…

#### But What’s with all this jargon?

As you shall see(0r may have already heard) there is a heck lot of nomenclature
associated with these two concepts…*Threads, Processes,
Gevents,greenlets,Actors,Hyperthreading,Multiprocessing,Go-Routines,Channels,AsyncIO,EventLoop…*

So what are all these[2] ? …**this isn’t the motive of this article** primarily
but we would try to understand a few of these(under specific conditions) on our
way…

**TOWARDS REAL STUFF…**

Enough of talking, let’s see CONCURRENCY in action.

And I choose Python as my language of choice.Yeah it’s a kinda controversial but
I would justify this by saying that this in favor of the larger audience.Python
is *not* a great way to do concurrency (observe its position in the
plot)…actually, it sucks at concurrency([3])…but still…

And another **warning** to make the code example a bit interesting, I’ll use the
socket module(you might wanna see
[this](https://pymotw.com/3/socket/addressing.html)).So things would tend to
*get a bit dirty from here on…so hang tight and don’t be shy of googling stuff*.

We’ll use Fibonacci function for demo,

```python
# Utility function for demonstration

def fib(n):
    if n <= 2:
        return 1
    else:
        return fib(n-1) + fib(n-2)

```

And here’s the server code, it listens on localhost and sends back the fib(n)
value:
```python
# server code

from fib import fib
from socket import *

def fib_server(address):
    # This sets up the socket(you can think that of as pipe over which communication happens) object
    sock = socket(AF_INET, SOCK_STREAM)
    sock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    # It binds to the address and listens for any connections
    sock.bind(address)
    sock.listen(5)


    while True:
        client, addr = sock.accept()
        print("Connection", addr)
        fib_handler(client)

# This function handles the connection and sends back the fib() value
def fib_handler(client):
    while True:
        req = client.recv(100)
        if not req:
            break
        n = int(req)
        result = fib(n)
        resp = str(result).encode('ascii') + b'\n'
        client.send(resp)
    print("Closed")

# This starts a server that listens to localhost on port 25000
fib_server(('', 25000))
```

Now start the server,

    $ python server.py

And in another terminal window,

    $ nc localhost 25000
      1
      1
      3
      2
      35
      9227465

Now this is all happening sequentially, So as to later compare our results we’ll
benchmark this,

```python
# Time of a long running request

from socket import *
import time

sock = socket(AF_INET, SOCK_STREAM)
sock.connect(('localhost', 25000))

while True:
    start = time.time()
    sock.send(b'30')
    resp = sock.recv(100)
    end = time.time()

print(end - start)
```

    # here are the numbers:

    0.2433168888092041
    0.22079825401306152
    0.22012019157409668
    0.2199845314025879

Now we’ll introduce threads,

A thread is:

* An **independent task running** inside a program

* Shares resources with the main program(memory, files, network connections, etc.)
* Has its own independent flow of execution…(stack, current instruction, etc.)

By using python’s threading module you can create **hundreds** of threads and
can give them **(target)function which they’ll execute independently of main
program**(THIS IS partially false…becoz GIL prevents simultaneous execution — it
here actually is preventing same shared memory to be accessed by two threads and
cause problems like changing a variable’s value simultaneously, so GIL in that
way is good)

Here’s the threaded-server,

```python

# threaded-server code

from fib import fib
from socket import *
from threading import Thread

def fib_server(address):
    sock = socket(AF_INET, SOCK_STREAM)
    sock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    sock.bind(address)
    sock.listen(5)

    while True:
        client, addr = sock.accept()
        print("Connection", addr)
        Thread(target=fib_handler, args=(client,), daemon=True).start()

def fib_handler(client):
    while True:
        req = client.recv(100)
        if not req:
            break
        n = int(req)
        result = fib(n)
        resp = str(result).encode('ascii') + b'\n'
        client.send(resp)
    print("Closed")

# This starts a server that listens to localhost on port 25000
fib_server(('', 25000))
```

Our benchmark shall echo the above point,

    $ python threading-server.py

    # In another terminal
    $ python perf.py

    0.22993946075439453
    0.22955703735351562
    0.23864316940307617
    0.23698139190673828

Compare this with earlier benchmark it’s almost same, To prove you, that it’s
not concurrent execution, open another window and run `perf.py`

    0.49178433418273926
    0.4784412384033203

it doubles, now open another terminal and run `perf.py ` it triples and so on…

NOTE: One benefit of using threads is that you could send multiple requests to
the server(each handled by a thread).Verify this with running server.py in another terminal window(**you can’t send
more than one request**).

So could we really do something *concurrently*…actually yes… python has got
something called  and it works by creating separate  that do not share state(for
a mental model…think of it as separate python interpreters).

But here’s the catch creating is costly(takes more time)…they are not as
lightweight as threads…but in our case creating new processes would speed up
things as we have socket -IO which is the slowest portion…

So here’s fully-concurrent code in python,

```python
# multiprocessing-server code

from fib import fib
from socket import *
from multiprocessing import Process

def fib_server(address):
    sock = socket(AF_INET, SOCK_STREAM)
    sock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    sock.bind(address)
    sock.listen(5)

    while True:
        client, addr = sock.accept()
        print("Connection", addr)
        workers = [Process(target=fib_handler, args=(client,)) for i in range(4)]
        for p in workers:
            p.daemon = True
            p.start()

def fib_handler(client):
    while True:
        req = client.recv(100)
        if not req:
            break
        n = int(req)
        result = fib(n)
        resp = str(result).encode('ascii') + b'\n'
        client.send(resp)
    print("Closed")

# This starts a server that listens to localhost on port 25000
fib_server(('', 25000))
```

    # Again do the measurement:
    0.26950716972351074
    0.272355318069458
    # it remains almost unchanged with increasing no. of new connections

#### CONCLUSION:

Now when someone says is good at concurrency what they mean is that it has got
some special constructs which are lightweight and do not share memory( they are
and  ). So I guess you do get some idea of what concurrency is…But this is not
even scratching the surface. Following are some links if you want to dive
deeper,

1.  For state of concurrency in python
[[here](http://www.dabeaz.com/usenix2009/concurrent/Concurrent.pdf)]
1.  David Beazley's talk
[[here](https://www.youtube.com/watch?v=MCs5OvhV9S4&t=896s)] introduces `concurrent-futures` module.
1.  Rob Pike’s talk “Concurrency is not
parallelism”[[here](https://www.youtube.com/watch?v=cN_DpYBzKso)]
1.  go-lang’s concurrency constructs
[[here](https://www.google.co.in/url?sa=t&rct=j&q=&esrc=s&source=web&cd=3&cad=rja&uact=8&ved=0ahUKEwjxwMbU9t7VAhUBN48KHYLHCwMQFgg0MAI&url=https://www.golang-book.com/books/intro/10&usg=AFQjCNFxHb4i6MKa5YoNAqwV-ujLNMENUw)]
1.  erlang’s concurrency model
[[here](http://erlang.org/doc/getting_started/conc_prog.html)][AT YOUR OWN RISK]

Hey amidst all this we forgot our goal *world-domination*, yup doing things
parallelly/concurrently is TOUGH :)

NOTE: There might be a follow-up article with concurrency implemented in some other language.





[1]: The [original
paper](http://www.cs.utexas.edu/users/EWD/transcriptions/EWD04xx/EWD476.html)
[somewhat readable].

[2]: So what’s the point in mentioning them? Just to **reiterate** the point
that this IS one of the **most complex problems** of computer science and there
have been many approaches to solve
it[[here](https://www.wikiwand.com/en/Concurrent_computing)]

[3]: There are actual/REAL issues with the way python is designed…IT DOES NOT
SUPPORT CONCURRENCY BY DESIGN…At the time of its creation(in 1994) it was
designed for single cores and it has (quite infamous) GIL (Global Interpreter
Lock) the lock which makes it inherently single threaded.
