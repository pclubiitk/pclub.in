---
layout: post
title: "Application of Biology to Optimization Algorithms"
date: 2016-08-07 11:25:00 +530
author: Arjun Sinha
website: 
category:
tags:
- tutorial
- optimization algorithms
- biology

categories:
- tutorial

image:
  url: 
---
## Application of Biology to Optimization Algorithms

Computer Science has left few fields untouched  Be it _electronics_, _networking_, _telecommunication_, _robotics_ and even _Biology_, computer science and algorithms have a role to play. So, it is really interesting to see that some parts of Nature too work according to a particular algorithm and set of rules and regulations. And whats even more surprising is that these set of rules that have been built into some natural phenomena also outperform normal algorithms when applied to standard computing problems.

The phenomenon being discussed here is **Swarm Intelligence**. It is a field that has been studied and researched for long and it has been concluded that there is a "method" to nature's madness. The random movement of bees,ants and birds is not really random but _actually follows a set of formulae_. Also the way that they move is quite intelligent and produces highly accurate, close to optimal results when applied to problems, most of them **NP hard** in nature.

Here I will discuss some natural phenomena that can be applied and are applied widely to several computing problems:

1. [**Ant Colony Optimization**](https://en.wikipedia.org/wiki/Ant_colony_optimization_algorithms)
	
    As the name suggests ACO models the problem on the basis of ant colonies. Usually the problems solved by ACO are modelled as graphs. The core idea of the algorithm is inspired from the pheromone depositing natue of ants. Initially a few random ants traverse the graph from the colony to the food and lay pheromones on the edges. Pheromones, as in real life, start evaporating. The ants that have been sent come back to the colony from the same path once they get the food. On their way back too they deposit pheromones on the edges. Now comes the important part: **A path with a shorter length will have more pheromone density a longer path.** This is because the ant on the shorter path had traversed a smaller amount of time before reinforcing the pheromones than one on the longer path.

	Now the new ants that go foraging for food will use the _pheromone feedback_ to determine their new path. Thus after some number of iterations the ACO will find the shortest path from the colony to the food.
    
    ACO has been used extensively to finding optimal and close to optimal solutions for more than 100 NP Hard problems. One obvious usage will be in the [Travelling Salesman Problem](https://en.wikipedia.org/wiki/Travelling_salesman_problem). One important thing to note is that ACO guarantees an optimal solution though the time that it will take to find one is not well defined. 
    
2.  [**Particle Swarm Optimization**](https://en.wikipedia.org/wiki/Particle_swarm_optimization)
	
    Particle swarm optimization (PSO) is an optimization algorithm modelled on the swarm movement of bees. In this algorithm the **particles** are possible solutions to the problem. We then move the solutions around depending on their velocity and position.The formulae encountered in moving these solutions is fairly simple. The movement of the particles are determined by the best position reached by the current particle and the best known position for all particles. As better solutions are found by the particles, the data is updated. In this manner, in some number of iterations, it is  that the particles will _swarm_ toward the best solutions.
    
    Unlike ACO, PSO does not guarantee that an optimal solution to the problem will be found. However, PSO works quite well in several optimization problems and is widely used.
    
    One advantage of optimization methods about PSO is that it needs _virtually no other information about the function to be optimized other than the value of the function at the points queried_ . This is unlike other methods like [gradient descent](https://en.wikipedia.org/wiki/Gradient_descent) which require the gradient of the function to find a solution and thus PSO works well with quite a lot of functions. 
    
3. [**Genetic Algorithms**](https://en.wikipedia.org/wiki/Genetic_algorithm)

	Again as the name suggests, this class of algorithms models the problems on the basis of genetics and each candidate solution is modelled as a generation. Their is a fitness function to evaluate a generation. Depending on the value of the fitness function, various changes take place in the gene structure such as _inheritance, mutation, selection and crossover._
    
    One critique of genetic algorithms is that they are too slow to find optimal solutions, which is quite apt as it is based on the concept of evolution.
    
Other metaheuristic algorithms are : [**Simulated Annealing**](https://en.wikipedia.org/wiki/Simulated_annealing) , [**Bees Algorithm**](https://en.wikipedia.org/wiki/Bees_algorithm) and other forms of Swarm Intelligence.

On a closing note , such metaheuristics can be applied to many NP hard and other optimization problems . Some examples of such problems are _scheduling problems_ and _routing problems_ among many others. 
