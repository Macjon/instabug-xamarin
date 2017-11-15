# Download Instabug via gradle

Download the Instabug .aar and .jar files via gradle.

### Gradle
Make sure you've installed Gradle. To test this, run the following comment in your terminal window:
```gradle -v```
You get an error when Gradle is not installed. To install Gradle on Mac, run ```brew install gradle``` in your terminal window.

#Download Instabug library
To download all the Instabug libraries, open a new terminal window and ```cd``` to this folder. When you have done this, run the following code:

	gradle downloadAndCopyLibs

#Clean
Run the following code in your terminal window:

	gradle clean