# ASCII Art Webcam in C#

A console-based application in **C#** that captures frames from the webcam, converts them to **ASCII art**, and displays the result in real-time on the console. 

## Features
- **Real-time image capture** from the webcam.
- **Image-to-ASCII conversion**, transforming grayscale pixels into ASCII characters based on brightness levels.
- **Display in console**, creating a unique ASCII art video effect.

## How It Works

1. The program captures images in real-time using the **Emgu.CV** library, a .NET wrapper for OpenCV.
2. Each captured frame is resized for better performance in the console.
3. The frame is converted to grayscale and mapped to a character in the ASCII set based on pixel brightness.
4. The ASCII characters are displayed on the console in real-time, producing an ASCII video effect.

## Requirements

- **Emgu.CV** (for webcam and image processing)
- **.NET Framework** or **.NET Core SDK**

Install Emgu.CV via NuGet:
```bash
Install-Package Emgu.CV
```

## Usage

1. Clone the repository and navigate to the project directory.
2. Ensure that Emgu.CV is installed in your project.
3. Run the application in the console.

## Example

As the program runs, it displays a live ASCII art feed from the webcam in your console.

##Disclaimer
You maybe need to zoom out your console to see it properly
