pclub.in
========

[![Build Status](https://travis-ci.org/pclubiitk/pclub.in.svg?branch=master)](https://travis-ci.org/pclubiitk/pclub.in)

Source for Jekyll based static-website cum blog for the *Programming Club* IIT Kanpur.
Based off: spaghetti.ga

## Test plan
First off, you'll need Ruby. Get `gem` with your package manager.
You should not be installing Jekyll directly, since that's likely to break things.
Instead, install bundle with 
```
gem install bundle
```

Then, execute these in the repo directory:
```
bundle install --path vendor/bundle
bundler exec jekyll server --port 8080 --host 0.0.0.0
```
Here the `--path` flag is optional to keep your system's packages sane.
