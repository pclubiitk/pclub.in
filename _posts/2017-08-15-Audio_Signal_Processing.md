**"Playing" with Audio**
================


Audio processing and comprehension is a very interesting and increasingly popular as well as useful area of study. A lot of methods have been devised and even more are being studied currently. Its applications are wide such as Youtube auto captions, PlayMusic lyrics, Shazam, Smule, Siri, Cortana, Google Speech to Text and many more. The purpose of this blog is to get a newbie acquainted to some of the very basic procedures to extract features from an audio recording or a sound track.


>You can read about one of the most fundamental audio signal processing problem **"The cocktail party problem" ** here-
 [The Cocktail Party Problem](http://www.brainfacts.org/sensing-thinking-behaving/awareness-and-attention/articles/2013/the-cocktail-party-problem/)
 
 
 >An interesting solution to the same can be found here -
 [Deep learning to solve Cocktail Party Problem](https://www.technologyreview.com/s/537101/deep-learning-machine-solves-the-cocktail-party-problem/)  *(Yes deep learning is magical!)*
 
 
 
 

Basic Audio Features
-------------


First, we'll talk about some basic features of an audio file. Intuitively, features like **frequency, power, amplitude, phase, zero crossings** etc sound relevant. Yes, they are indeed important but we often use features which are simple or complicated functions of these simple features.


- One such suite of features is the **MFCCs**. MFCCs analysis is focused on extracting features for automatic speech recognition systems. This analysis includes filtering linguistic features and discarding background noise, emotion etc. Details can be found [here](http://practicalcryptography.com/miscellaneous/machine-learning/guide-mel-frequency-cepstral-coefficients-mfccs/) .


- Extracting musical features of often more complicated and involves dealing directly with an **audio spectrogram**.  Below is a typical spectrogram of an audio track plotted using [Sonic Visualiser](http://www.sonicvisualiser.org/).


![alt text](http://imgur.com/Hk3MI1g.jpg "Spectrogram")



> Spectrogram is a plot of amount of frequencies contained in a wave vs the time.


> - The frequency regions which seem to be **Hot** *(in the sense that they are more luminous)* have a greater intensity fraction.


> - A simple application of the spectrogram includes finding the dominant pitch in a certain time frame hence helping find the key of song. It can also be used to analyse different voices in an audio sample.





----------------------------------------------
Fast Fourier Transformation (FFT)
-----------


To analyse a complex wave, we break it down into various simple sinusoidal waves with different frequencies such that the superimposition of these simple waves give back the original wave. 
Following is a **Discrete Fourier Transform (DFT)** of a signal x(t<sub>n</sub>).


![alt text](http://imgur.com/2zNT7zh.png "DFT Equation")


![alt text](http://imgur.com/ukBWTN8.png "Symbols")


FFT is an efficient algorithm to calculate the DFT of a wave. DFT takes **N<sup>2</sup>** operations whereas FFT takes only **Nlog<sub>2</sub>N** operations.


----------------------
<h4>FFT Implementation in Python using <b>Scipy</b></h4>


Scipy is an open source numerical and scientific computation library for python which comes with *fft* package. Following is an implementation of the *fft* function defined in the scipy *fftpack*. 


**Input signal** - *x(N) = sin(50(2πNT)) + 0.5sin(80(2πNT))*


```python
>>> from scipy.fftpack import fft
>>> # Number of sample points
>>> N = 600
>>> # sample spacing
>>> T = 1.0 / 800.0
>>> x = np.linspace(0.0, N*T, N)
>>> y = np.sin(50.0 * 2.0*np.pi*x) + 0.5*np.sin(80.0 * 2.0*np.pi*x)
>>> yf = fft(y)
>>> xf = np.linspace(0.0, 1.0/(2.0*T), N//2)
>>> import matplotlib.pyplot as plt
>>> plt.plot(xf, 2.0/N * np.abs(yf[0:N//2]))
>>> plt.grid()
>>> plt.show()
```


![alt text](http://i.imgur.com/NPoqeJZ.png "FFT")


- Clearly the graph shows the distribution of the signal in various frequencies and matches our intuition because the input wave is essentially a combination of two simple waves of frequency 50Hz and 80Hz each.


--------------
<h4>Implementing on a wav file</h4>


```python
>>> import matplotlib.pyplot as plt
>>> import numpy as np
>>> from scipy.io.wavfile import read
>>> #read sampling rate and signal values from the file
>>> rate, signal = read('file.wav','r')
>>> time = np.arange(len(signal))
>>> time = time/float(rate)
>>> #plot a section of the audio file
>>> plt.plot(time[7000:10000],signal[7000:10000])
>>> plt.show()

```


![alt text](http://imgur.com/K4liL3B.png "FFT wave file")


<above steps link to FFT using scipy>
Treating this as the input wave, the above steps can be repeated to get the FFT of any audio file. You can also find the spectrogram by performing the above analysis for appropriate window size and plotting the results.




Conclusion
----------


I hope this post gives you a brief overview of how audio signal processing is done. This is just the surface of the subject and much more sophisticated code is used in production but this much knowledge can be used to solve seemingly complex problems. Once we have the wave and we know how to calculate it's FFT, we can plot spectrograms, find MOOCs and a whole lot of things.


Interesting applications-
----------

- Separating components of a song - https://www.sisec17.audiolabs-erlangen.de/#/   *(Website hosting samples from various source separation algorithms)*


- Google's project on Music Generation - https://magenta.tensorflow.org/welcome-to-magenta


- Small web implementations of ASP with open source code on github - https://webaudiodemos.appspot.com/

Github - https://github.com/cwilso
