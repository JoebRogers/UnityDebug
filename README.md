[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-brightgreen.svg)](https://github.com/JoebRogers/Unity-Debug-Util/graphs/commit-activity) 
[![License](https://img.shields.io/github/license/mashape/apistatus.svg)](https://en.wikipedia.org/wiki/MIT_License) 
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://joebrogers.com) 
[![Twitter Follow](https://img.shields.io/twitter/follow/JoebMakesGames.svg?style=social&label=Follow)](https://twitter.com/JoebMakesGames)
[![Made With Unity](https://img.shields.io/badge/Made%20With-Unity-57b9d3.svg?style=flat&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAMAAAAolt3jAAABklBMVEUIJCYRLjARLzEWICcbIyYcLDQdJS4dKjMdLTQeKTMeKTUeKjMeKzMeKzQeNDceNTkeNzkeODkfIy8fJi8fJjAfMDQgJzEgKDIgKTIgMTUgMjkhJjAhKDMhKTIhKTQhKzYhLDYhLDchLjUhLjYiKTAiLDciLTgjKjIjLTcjLjkkLTgnKDYnKTYnLjb%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F9oVHO%2FAAAAhXRSTlMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQUGCAkMDhATFBcZGh0hIyYtNT1IS05RVFZXW1xeYWNnbG9wcXN2eHt9goaKkpWXo6usrbCztLW2ubq7vL2%2Bv8HDxsjKzNfY5OXn6%2Bzt8fP09vj5%2FP3%2BxDGH3QAAAMlJREFUeAFjUFTiZ5AWEFQ1dgwvDuIEc8WkHDJrW1tb07nBXHOb%2FPIYz7LWSgsgl8%2B9NclWjz24LrTVmUFR2b0110SE1aYhyqg%2BmkHRozXNkE2LI67KXDy7iMG7uTUnITU5s9WXhSfQi8GvtbUgMz%2BvsNVLSMbfjUHUpzVRX0VXPb7ClCujiEGSyac1xUhY1q4pwqAulkGSkdmnNd5KTiKsJqDVBcTVtLbPL410LW%2BptgRz5dUcixpbW1qzuMFcBW0dDTOnqJIQXgB6SzT11MCPiQAAAABJRU5ErkJggg%3D%3D)](https://unity3d.com)

![](https://github.com/JoebRogers/Unity-Debug-Util/blob/master/Banner.png)

UnityDebug is a small script to wrap Unity's Debug logging calls to enforce strict calling intent on which debugging calls make it into compiled builds.

## How does it work?

The script contains a static class `InternalDebug`, wrapping all `UnityEngine.Debug` calls with conditional attributes. Any calls made from this class will only be preserved when the project is built with the "Development Build" option checked in the "Build Settings" window, (or alternatively, the `Development` flag set in `BuildOptions`).

## Why would I need this?

It's a common misconception for newer developers working with Unity to expect debug calls to be stripped out of game builds. This is not the case. It's all too easy to leave debug calls lying around within your scripts, that will be using up potentially precious performance under the hood (that `Debug.LogWarning` you left in `Update` is really going to come back to bite you). 

Even for experienced developers, there's definite distinction between the debug calls you utilise during every day development and those you want to ship with final builds in order to aid in debugging user-submitted bugs. It can quickly become a cumbersome annoyance to find+comment/uncomment these calls, or even strip and replace every time you need to build.

By utilising a script like this, it'll not only save you work by automatically stripping out internal debug calls, but it's also *explicit* about the intent of particular logs. Being able to immediately discern the intent of particular calls, especially in a team environment is a big aid in streamlining the shipping process.

## Things to know

There are two variants of this script you can use, one of which is the raw `.cs` file, which can be found in the `src` folder. The other, is a `.dll` file of the compiled script, which can be found in `bin`. The difference here, is that when using the raw script version, double-clicking on the logged message in the console window _won't_ jump you to the line referred to, but rather the debug script. Using the compiled `.dll` file circumvents this issue.

Also, unlike the traditional Unity methods, there are also overloaded versions of all `Log` methods which take in a conditional argument (defaults to true). Allowing you to pass in your conditions, rather than wrapping your method calls - in turn, doing things this way also means that the condition itself is stripped from the build.

## How do I use this?

It's as simple as dropping either the script file or `.dll` into your project window and replacing any calls to `Debug.` (or `UnityEngine.Debug.`) with `InternalDebug.` (or `Utilities.InternaDebug.` if you don't include the namespace). The arguments have been left as-is, with any additions being made as overloads, so nothing should need to change about your current project set up at all.

## Enjoy!
