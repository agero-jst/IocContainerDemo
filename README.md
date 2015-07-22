# IocContainerDemo
Demo files for IoC container presentation

This repository contains a C# 4.5.1 solution with the purpose of demonstrating
how to configure and use IoC containers.

The solution includes a trivial implementation of an IoC container in the 
IocContainer folder, as well as references to Castle Windsor and Unity.
Due to the author's focus, emphasis has been placed on the Castle Windsor 
configuration.

The application engine itself is a simple object oriented application 
simulating a process for filling a bag and place it in a box. The model 
includes various entities (of admittedly somewhat questionable relevance) for 
providing a bag, building a box, closing the box upon filling etc.

In the NonIoCPackingEngine folder, an alternative "bad" version of the code is
included. This version features high coupling due to the various entities 
initializing each other. It is provided as an example of how NOT to do.

For further information, contact:
Johan Strömhielm 
Agero AB 
Stockholm, Sweden