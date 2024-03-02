# Calculator Software: Technical Documentation
Ridhiman Dhindsa, 210101088  
Date: 29 Jan 2024

## How to run
1) Open the Calculator directory in Visual Studio 2010.  
2) Press the `Run` button in the toolbar at the top, or press F5.   
3) The calculator software starts running. Enter the desired inputs.  

## Description
Developed a simple graphic calculator that handles the operations
(+,-,*,/). Limits of calculation range from [-10^9,10^9]. Inputs are also limited to this range, and rounded off to 7 decimal places. Error handling has also been included, which covers the following cases:  
1) `Beyond calculation scope:` If any 1 of the 2 numbers entered is outside the above mentioned range, this error is displayed. Also if after performing the calculation the result is beyond the range, this error is displayed.  
2) `Invalid input:` If the entered input is not in numeric format or there is a syntax error, this error is displayed. Eg: 12.3.53 + 23 etc.   
3) `Division by 0 not allowed:` If the second number entered, i.e. the divisor is zero, then this error is displayed. 
4) **Multiple operator buttons pressed:**  If multiple operator buttons are pressed, the last operation and the number on the last line of display are considered.  

## Tools used
* Visual Studio 2010 as the development environment.  
* C++ for developing the logic and algorithm.  
* Visual Basic Windows Forms Application for developing the GUI. (Complete with inline comments)   
* MarkDown for the Technical documentation.  
* User Documentation available in PDF format.  

## Functions used
Each button has its own defining function.

*Inputs for Event Handler functions:*  
* **ByVal sender As System.Object:** This parameter represents the object that raised the event. In this case, it represents the button that was clicked. The ByVal keyword indicates that the parameter is passed by value, meaning that a copy of the object's reference is passed to the subroutine.  
* **ByVal e As System.EventArgs:** This parameter represents the event arguments associated with the event. In this case, it represents the EventArgs object associated with the Click event. The ByVal keyword indicates that the parameter is passed by value, meaning that a copy of the EventArgs object is passed to the subroutine.    

### 1) Digit buttons: (0,1,..9)
`ButtonX_Click()`   
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Appends the digit X on display.    

### 2) Clear button: (C)
`clearbutton_Click()`   
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Clears the calculator display.    

### 3) Operator buttons: (+,-,*,/)
`addbutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the first number to operated on, and appends + operator after it. Also does validation checks on the number entered.  

`subtractbutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the first number to operated on, and appends - operator after it. Also does validation checks on the number entered.  

`multiplybutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the first number to operated on, and appends * operator after it. Also does validation checks on the number entered.  

`dividebutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the first number to operated on, and appends / operator after it. Also does validation checks on the number entered.  

### 4) Decimal point button: (.)
`dotbutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Appends the decimal point to the last line of display.  

### 5) Equal button: (=)
`equalbutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the second number to be operated on, and performs validation checks on it. Then calculates the result and rounds off to 7 decimal places.  

### 6) Backspace button: (Back)
`backspace_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Removes last character from string in the display.    

### 7) Sign button: (+/-)
`signbutton_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Toggles between positive or negative sign of the number on the last line of display. To do so it stores n-1 lines in a separate array and appends the last (nth) modified line to it.     
