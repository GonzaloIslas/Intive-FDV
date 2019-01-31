Introduction

For this test i applied a 3 different desing patters, which i will explain later, that included singleton, 
strategy and visitor. I limited myself to cover the whole extent of the test, which means i left out some key features and
concepts that where beyond the scope of the project

Implemented patterns

I implemented the singleton patter in order not to instansiate a new dictionary everytime i needed to do a simple get of
an common atribute. I also found that, where this system to grow exponetialy, i would use up a whole lot o memory in vain.
So i decided to apply the singleton to both RatesStrategy and Discounter. One may wonder why i didnt made the class static them,
as i would access it in a static way non the less. I made it this way since i had to store variables (the hourly, daily, weekly and Family rates and discounts).
So, same situation, where this to scale i would have to manually add the new values. And this is true for both my implementation
and a static solution, but if i where to connect to a db to get those values i would have to re do less code.

Moving over to the strategy patter, i choose it by the simple reason that things may change in the future or i may need to implement
new rates/discounts. So i created a dictionary with the corresponding key (A clear enum so that you dont need to overthink or
work backwards what the key might be) and a delegate as a value to execute. Adding a new feature is as simple as; Add a new entry
to the corresponding enum, add a new method that you want paired with that, added it to the contructor of the dictionary and thats it.

Lastly we have the visitor, i made the choice to use this patter to encapsulate a common method that is widely use. And also
combine it with a strategy so i could add new discounts in the future with ease. If i need
to change something in the future about that method i am encapsulating, i just need to go to the method the visitor is implementing
and its done. No more code needs to be re-touched and, as consequence, re-test it.

Things i left out

Some of the key features i didnt implement are;
A service Class: I intended to implement a layer of abstraction to handle the domain classes as well as some of the utilities
i created. While on the drawing board i realized that it wasn't really necessary to implement said layer, since the only class
that would (in this particular test) be a test class.
The Id of the classes: Since i wasn't tasked to connect the system with a db, i found little to no use for an id. Again, for this 
particular test.

To sum-up

I implemented a system that meets the required functionality. The system is able to grow in features as well as in workloads
since i tried to minimiced the used memory and evade unnecessary complexity.