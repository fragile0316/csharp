## ConsoleRegisterStudent & WPFRegisterStudent

### Briefly summarize the requirements and goals of the application you developed. What user needs was this application designed to address?

The ConsoleRegisterStudent is a console app, while WPFRegisterStudent uses the Windows Presentation Foundation UI framework. These programs enable students to register for courses. Students select from a menu of courses for which they wish to register.

#### Program Requirements

* No validation of the type of user input (e.g., Is it a string?) is checked or required.
* Each course carries three credit hours.
* The program terminates only when the student requires it.
* No registration of other courses not displayed by the program
* No registration more than once for the same course
* No registration for more than nine credit hours (e.g., no more than three courses)
* The program validates the user's selection. If the selection is valid, the program registers the student for the selected course. Otherwise, the program outputs an error message. The program then outputs the current list of registered classes and asks the user if they want to register for another course.

### What did you do particularly well in developing this application?

My best work was developing the business logic that satisfied the program requirements. This involved validating the user's selected course by checking if it was already registered or if the user would go over the nine credit hours limit, then displaying the user's current registered courses.

### Compare and contrast the Console and WPF application designs. What screens and features were necessary to support user needs and produce a user-centered UI for the app? How did your UI designs keep users in mind? Why were your designs successful?

A terminal is needed to run and interact with the ConsoleRegisterStudent app. The WPFRegisterStudent app will create a GUI for Windows Desktop for users to interact with. 

A loop was necessary for the console app to get multiple of the user's selected courses, but it was not necessary for the WPF app since a button listener was used whenever a user selected a course.

For the console app, prompts and selectable course items were separated by new lines to make the instructions and menu options easy for the user to read. 

For the WPF app, UI components needed to be positioned so that they did not overlap and were intuitive to understand and interact with since common UI elements were used, like a dropdown menu (combobox) and buttons.

### How did you approach the process of debugging and coding your application? What techniques or strategies did you use? How could you use those techniques or strategies in the future?

My most common methodology is to first understand the app's objectives. Then, I create a list of general things the program needs to handle before implementing these features. Then, if I am debugging, I will try to walk through the program line by line and see if there are any hiccups or errors that need to be fixed.
If I am still stuck and on a deadline, I ask a peer for help if they have encountered a similar problem. If I still have problems, I will research and experiment until I find a solution. I often find myself using this methodology for all types of problem-solving.

### Where did you have to be innovative to overcome a challenge in the full application development process?

I was not very familiar with working with WPF apps. It was very interesting to me how UI components could be referenced in the C# program and how I chose to use this knowledge to modify and update texts in the GUI.
