# <p style="text-align: center;">*संस्कृतोरक्षनम्</p> <p style="text-align: center;">(Sanskritorakshanam)*</p>

## *Preserving Sanskrit Texts - Introduction* 

Sanskrit literature is a treasure trove of ancient wisdom. Many of its semantics and rules of grammar very well justifies why it is called so. Much of it is presented in poetic form following the intricate rules of Sanskrit prosody or Chandaḥśāstra. However one of the challenges in preserving Sanskrit texts we are facing today is errors that creep in while copying or transliteration. When the texts are passed on from generation to generation, we can expect errors which might have inadvertently crept in. Especially when digital copies are made. This is mainly due to human errors or errors by OCR (Optical Character Recognition) algorithms while reading.

So how will we go about doing this ? preserving Sanskrit texts? Well, Natural Language Processing(NLP) has got the answer. NLP is nothing but a computational tool to make computers understand Human language semantics like meaning, grammar, sentiments etc. Here we present the main algorithm and its explanation which makes things work.



## *Background Desideratum- Chandas come to the Rescue*

The classification of syllables into laghu (short) and guru (long) forms the core concept of Chandaḥśāstra Deo (2007). The classification is related to the amount of time it takes to pronounce a specific syllable; in particular, the short syllables are termed laghu and the long syllables guru. These laghu-guru patterns vary in complexity and follow specific rules for syllable alternation, creating different rhythms or chandas. Here’s the list of keywords which we will use in this blog hereon:



·  	*Chanda :* Sanskrit meters

·  	*Śloka :* Verse

·  	*Pāda :* A verse (śloka) is composed of four parts, each known as a pāda

·  	*lg-signature :* The unique sequence of laghu-guru markers used to identify a meter (e.g LGGLGGLGGLLG is the lg – signature for ‘नमेसदा वलेमातृभम’)

## *NLP and Chandas do the trick*

The fundamental concept of error analysis in a Sanskrit text lies in the identification of what chanda the given text corresponds to. If we get the idea of what meter the text is trying to follow, and a few points where it’s going off the track, they are probably the mistakes we are looking for.

Now For the meter Identification we follow these simple steps:

1) *Pāda Split:* The contiguous text is split into lines (pādas) based on several standard line-end markers, such as ‘\n’, ‘।’, ‘॥’ and ‘.

1) *Syllabification:* The process of splitting text into syllables is fairly straightforward for the majority of Indian languages due to phonetic consistency of the alphabet. So let’s go back to your middle school Hindi/Sanskrit classes. Observe that the Unicode (a type of encoding for texts) string “भारत” consists of 4 Unicode characters: ‘भ’, ‘◌ा’, ‘र’ and ‘त’ and you are there. We use the sanskrit-text Python library to perform this task.                       ### Can be better explained.

1) *Laghu-Guru Marks:* Here comes the protagonist of our story. The last step is to make the lg-signature of each *Pāda.*  Standard rules of Sanskrit prosody described in numerous articles (Deo, 2007; Melnad et al., 2013; Rajagopalan, 2020) are followed to mark each syllable as laghu or guru. Reiterating the aforementioned example, lg – signature for ‘नमेसदा वलेमातृभम’ is LGGLGGLGGLLG.    ### Unclear. Elaborate. 

## *It’s Algorithms’ turn to cast their spell*

Once we are ready with the lg-signature of the whole document, we put it through our algorithms. We’ll ofcourse use an object-oriented approach to go about this. First lets understand the structure of the two python dictionaries which build up our metrical Database (MD):

    CHANDA_SINGLE ={
    'LGGLGGLGGLGG': ['Bhujaṅgaprayāta'], '[LG][LG][LG][LG]LG[LG][LG]': ['Anuṣṭubh (Pāda 1)'], '[LG][LG][LG][LG]LGL[LG]': ['Anuṣṭubh (Pāda 2)'] 
    
    } 
    
    CHANDA_MULTIPLE = {
    
    'LGGLGGLGGLGGLGGLGGLGGLGG': ['Bhujaṅgaprayāta (Pāda 1-2)'], '[LG][LG][LG][LG]LG[LG][LG][LG][LG][LG][LG]LGL[LG]': ['Anuṣṭubh (Pāda 1-2)']
    
    } 

Woah what’s this now ? Well it’s as trivial as confusing it may seem. The ‘CHANDA\_SINGLE’ dictionary has the *lg-signature* of a **Pāda* as the ‘key’  and the type of prosody/meter that it corresponds to as the value of this ‘Key-value’ pair and “CHANDA\_MULTIPLE” consists of lg-signatures of a *Pāda* as well as that of its neighbors. What’s the utility of the “CHANDA\_MULTIPLE” dictionary ? Well this acts as a failsafe if the Line end markers (‘\n’, ‘।’, ‘॥’ and ‘.) are missing.

What follows next ? Our dear algorithms which find the errors ! Their structure is as follows :

- *Direct Matching:* Take the lg-signature* of a **Pāda,* find its direct match in the metrical database (MD). If found, there are probably no errors in the *Pāda.* If not, we find fuzzy matches. 
- *Fuzzy Matching :* We find fuzzy matches as in the closest lg-signature to the one of the given *Pāda.* Accordingly we can make suggestions as to what to insert,delete or replace. 

For finding the closest match we use a concept called Levenshtein edit distance which is simply the number of characters needed to be replaced to arrive at the target string. For example Levenshtein edit distance between LLG and LGL is 2 and that between LGL and GLG is 3. For computational purposes we compute the Levenshtein Similarity as:

![Levenshtein Similarity Equation](https://latex.codecogs.com/svg.latex?Levenshtein%20similarity%20=%201%20-%20\frac{Levenshtein%20distance}{\text{length%20of%20target%20match}})

### *The meter Identification Algorithm*

The meter identification algorithm performs a dictionary lookup to try and match the lg-signature with the metrical database created above. That is it tries to directly match the lg-signature with a specific *Pāda,* failing which it attempts to find the closest match using ‘fuzzy matching’. Then it returns the direct match result and the fuzzy match result, if any.

---
### Algorithm 1: Meter Identification
**Data** : Metrical Database (MD)  
**Input** : lg-signatures corresponding to each ‘line’ in the input (T = {lg1, lg2, . . . , lgn})  
**Output**: Result set containing exact or fuzzy matches  

**forall** lg ∈ T **do**  
&emsp;SM1 = FindDirectMatch(lg, ‘CHANDA_SINGLE’)  
&emsp;SM2 = FindDirectMatch(lg, ‘CHANDA_MULTIPLE’)  
&emsp;RM = FindRegexMatch(lg, ‘CHANDA_SINGLE’ + ‘CHANDA_MULTIPLE’)  
&emsp;DM = SM1 + SM2 + RM  
&emsp;FM = ϕ  
&emsp;**if** DM = ϕ **then**  
&emsp;&emsp; FM = FindFuzzyMatch(lg)  
&emsp;**end**   
&emsp;**return** DM + FM  
**end**

---
### *The Direct match algorithm*

This is where the dictionary lookup of exact lg-signatures is implemented. However, if it fails to find a direct match with the metrical dataset initially, it changes the last marker in lg-signatures into guru and tries to find a match again. This is because there exist meters in *Chandaḥśāstra* where the last signature is laghu (in contrast to the general rule of *Piṅgala’s Chandaḥśāstra* that last syllable is always a Guru )*  and those whose last signature is laghu. Then it returns the match result, which is null if it isn’t able to find one.

---
### Algorithm 2: Direct Matching
**Input** : lg-signature  
**Output**: Result set containing exact matches  

**Function** FindDirectMatch (lg, ‘MD’)  
&emsp;M1 = Query(lg, ‘MD’)  &emsp;`// dictionary lookup`    
&emsp;M2 = ϕ      
&emsp;RM = FindRegexMatch(lg, ‘CHANDA_SINGLE’ + ‘CHANDA_MULTIPLE’)    
&emsp;**if** M1 = ϕ **then** &emsp;`// if no match found`  
&emsp;&emsp;**if** the last letter of lg is laghu **then**  
&emsp;&emsp;&emsp;lg1 = replace last letter of lg with guru  
&emsp;&emsp;&emsp;M2 = Query(lg1, ‘MD’)  
&emsp;&emsp;**end**  
&emsp;**end**  
&emsp;**return** M1 + M2  

---

### *The Fuzzy algorithm*

This algorithm is executed when there is no direct match of the chanda with the metrical database. The ‘k’ referred to in the algorithm is the number of suggestions of closest matches that will be returned by this function. It iterates through all the chandas in the metrical database, calculating the cost and suggested chandas using the ‘Transform String Sequences’ algorithm. The cost here is actually the Levenshtein edit distance, i.e., how many edit operations to do to the lg-signature to get to the chanda currently being tested against. Then it returns the k least cost results.

---
### Algorithm 3: Fuzzy Matching
**Input** : lg-signature and k  
**Output**: Result set containing top k fuzzy matches  

**Function** FindFuzzyMatch (lg, ‘MD’, k)    
&emsp;results = ϕ   
&emsp;**forall** chanda in ‘MD’ **do**       
&emsp;&emsp;cost, suggestion = Transform(lg, lg-signature of chanda)      
&emsp;&emsp;**if** suggestion **then**     
&emsp;&emsp;&emsp;results += (chanda, cost, suggestion)    
&emsp;&emsp;**end**  
&emsp;**end**  
&emsp;**return** top-k results with lowest cost

---
### *The Transform String Sequences algorithm*

This algorithm takes two sequences of lg-signatures as input and finds the Levenshtein edit distance using the **python-Levenshtein** library in python. Then it calculates the number of edit operations while treating ‘replace’, ‘delete’, and ‘insert’ operations with equal weightage. This is referred to as cost.  

---
### Algorithm 4: Transform String Sequences
**Input** : String sequences seq1, seq2   
**Output**: Suggested edit operations required to transform seq1 into seq2 and the cost of
transformation  

**Function** Transform(seq1, seq2)    
&emsp;edit_ops = GetLevenshteinEditOps(seq1, seq2) &emsp;`// using python-Levenshtein`  
&emsp;weights = {‘replace’: 1, ‘delete’: 1, ‘insert’: 1}  
&emsp;cost = $\sum_{op \  ∈ \  edit\_ops} weights[op]$  
&emsp;suggestion = AddEditOpsMarkers(seq1, edit_ops)&emsp;`// add suggestions`  
&emsp;**return** cost, suggestion  

---

## *Conclusion and Acknowledgements*

Thus, we have seen how using NLP, it's possible to facilitate an efficient error correction system and to detect meters even from erroneous text. Our blog is heavily inspired from the paper on *Chandojñānam*,  which along with the above algorithms has also implemented a user-friendly interface enabling the user to provide input as text or image files. There are also earlier versions of such software, the most famous being Rajagopalan(2020) and Neill(2022) which although not as accurate as Chandojñānam are worthy contributions in this field and paved the way for further innovation.
	### Where is error correcttion descrivbed?? 

## *References*

[1]  Hrishikesh Terdalkar, Arnab Bhattacharya, [Chandojnanam: A Sanskrit Meter Identification and Utilization System](https://arxiv.org/ftp/arxiv/papers/2209/2209.14924.pdf).

[2] [Python Levenshtein.editops() Functions](https://www.programcreek.com/python/example/113374/Levenshtein.editops), blog post.

[3] Abhilash Rajendran, [Science of Metrics Or Prosody In Hinduism – Chanda Shastra](https://www.hindu-blog.com/2020/09/science-of-metrics-or-prosody-in.html), blog post.
