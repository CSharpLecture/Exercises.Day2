# Exercises.Day2

Exercises and solutions for the second day.

## 6. Write a swap method

Write a simple method called `Swap()` to exchange to given integers. The method should work in such a way, that the following program works:

    int a = 0;
    int b = 1;
    //Calling Swap with a and b

    if (a != 1 || b!= 0)
    	throw new Exception("Swap does not work yet!");

    Console.WriteLine("Swap seems to work for this case!");

## 7. Guess a number

Write a guess-a-number game. The .NET random generator is available by generating a new instance of the `Random` class. The game should give the user the opportunity to enter the range of numbers. Based on this range the number of tries should be determined (you can decide how hard the game should be). For each try the user has the ability to guess a number. If the guessed number is the generated number, then the user won the game. If the number of tries has been exceeded, the user lost the game.

## 8. Simple numerical integration

Approximate the integral of a function by taking the sum of the areas of rectangles, i.e. compute

![equation](http://www.sciweavers.org/tex2img.php?eq=F%3D%20%5Cint_a%5Eb%20f%28x%29%20dx%20%5Capprox%20%5CDelta%20x%20%5Csum_i%20f%28x_i%29&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

Pack everything in a method called `Integrate`. This method should take 4 input parameters:

* A `double`, which represents the start of the integral a.
* A `double`, which represents the end of the integral b.
* An `int`, which represents the number of rectangles N.
* A `Func&lt;double, double&gt;`, which represents the function f.

Use your method to show that the value of the integral is becoming more precise as N increases.

## 9. Digit sum

Create a method, which has an `int` argument (called number) and an `out` of `int` argument (called digits). The return type should be an `int` as well.

This method would then compute the digit sum of all digits in the given number argument. The digits argument should be set to the number of given digits in number, while the result of the computation would be returned.

## 10. A useful class

Create a class, which simplifies receiving user input in the console. The class should have a default constructor and another constructor, which requires a `string` to be passed. The given `string` should be used as the message for the user the prompt. In case of the default constructor a default message should be displayed.

The class should have a method called `ParseInt()` and another method called `ParseDouble()`. The `ParseInt()` method will try to get a valid integer value. If no valid integer value is passed in, it will display an error message and prompt the user to enter a valid integer value. Once a valid integer value is passed in, this loop is broken and the value is returned. The `ParseDouble()` method does the same with a floating point value instead of an integer.

## License
This work is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).