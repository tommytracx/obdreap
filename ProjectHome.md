In the search I have made for software interfaces to OBD hardware I have become frustrated in finding one that matches my needs. One package would offer something I like that another did not have only lack a critical component that made it completely worthless to me.

# The following is a list of minimum requirements. #

---


  * Language still yet to be determined
    1. Python seems to be the platform independent choice, however, deployment requires that Python RTE be installed
    1. Java is another viable choice, however, same issue as above
    1. C# is the preferred language, however, out of the choices the least platform dependent.      Given the requirement that **minimal** apis incorporated this will need to be investigated

  * This project will focus on Test Driven Development.
    1. It will begin by developing an application that will use actual data to verify the  created tests.  (emulation)
    1. It will continue to create the application that will take the data and log it to a file (translation)
    1. It will continue by interfacing the resultant data to communication technology (bluetooth, IrDa, Wifi, etc) (communication)
    1. Finally a mobile application will be developed

  * Needs to be very easy to install and deploy, minimal requirements and minimal libraries. Preference given to Windows platforms (the majority). But not complete if only partially supported in Linux. This project stresses **reduction in external api requirements** if any design requires a hardware module that item will be stubbed out and a platform blind module will be developed inline.

  * Needs it to be "Always On" that means it has 2 modes
    1. ON and not looking for a connection and
    1. ON and looking for a connection. _This requirement allows this application to work as a logger and when the hardware is not robust enough to maintain    communication through_

  * A testing interface to enhance and encourage developers to add other behavior to this application
    1. This requires a method to allow other developers to contribute modules or plugins to this project

  * Whatever language this application is written in it most be coded with a very rudimentary style avoiding complex language specific structures _(i.e no generics, no anonymous methods, no  extra apis)_ This is to insure that if in the future we need to port to another languuage this can be done more easily.

  * A Mobile interface that communicates with a device attached to the OBD interface that allowing specific data items to be displayed in a "heads up fashion"
    1. This requirement will be in V2 of this spec
    1. The display will be able to be modified by the user so that only the information that she wants will be displayed.

  * A website that allows the user to display and analyze the data and determine ways to benefit fuel efficiency, speed, performance, etc.