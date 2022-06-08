This is a simple Stopwatch C# console application. It is presented to the user a Menu with the following options:

![image](https://user-images.githubusercontent.com/36134456/172715795-082cb647-4efe-4cfc-b2ba-171847fb3951.png)


We start by performing a validation of the user choice. If:
1.	We can successfully parse the user choice to an int, then we proceed with stopwatch
2.	We can't successfully parse the user choice to an int OR the user choice is not among the options displayed in the menu, then we display the message "**Invalid option!**"


If:
1.	The user selects option "**1 - Start**", the timer will start
2.	The user selects option "**2 - Stop**", the timer will stop and a message will be displayed in the console stating the duration of the timer
3.	The user selects option "**3 - Clear**", the timer will be cleared and set to "**00:00:00**" 

**Important notes about the functionality of this application:**
- If the user selected option "**1 - Start**", the stopwatch started, so the user can't start again the timer because it is already running. In such case, an exception will be raised stating that the application is already started. To be able to start again the timer, user should select option "**2 - Stop**" or "**3 - Clear**".
- If the stopwatch is already stopped and the user selects option "**2 - Stop**", it will raise an exception in the console stating that the stopwatch is already stopped.

