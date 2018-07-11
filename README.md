## Demo

Please follow [this link](http://128.199.172.229:8888/) to see the carousel in action.

## Run binaries

Download [the latest distribution archive](https://github.com/PavelBastov/carousel/blob/master/dist/carousel-0.0.1.zip?raw=true) and unpack it somewhere.

Launch command shell and `cd` into the unpacked folder. Run `mono server.exe` if you are on Linux/OS X or just `server.exe` if you are on Windows.

(Please note that you have to have Mono installed on Linux/OS X.)

Navigate to [http://localhost:8888](http://localhost:8888) in the browser.

## Run from source

_I've been doing this on Windows, so the instructions below only apply if you are on Windows, too. Running from source has not been tested on Linux/OS X._

**Run backend server**

Run Visual Studio 2017 Community Edition and open the `server.sln` file. Press `F5` to build and run the solution.

**Run frontend server**

`cd` to the client directory and run `npm start`.

Navigate to [http://localhost:3000](http://localhost:3000) in the browser.

## Ways to improve

Below is a list of things off the top of my head that can be improved in the project:

* Add unit tests to frontend :P
* Merge the pictures on the fly into one sprite and use it as background image on the picture div (with the proper offset). This will remove the flicker when going from picture to picture
* Add swipe gesture handling (for mobile/tablet)
* Add picture transition effects (fade in or slide in)