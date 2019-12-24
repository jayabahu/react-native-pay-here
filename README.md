
# react-native-pay-here

## Getting started

`$ npm install react-native-pay-here --save`

### Mostly automatic installation

`$ react-native link react-native-pay-here`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-pay-here` and add `RNPayHere.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNPayHere.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNPayHerePackage;` to the imports at the top of the file
  - Add `new RNPayHerePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-pay-here'
  	project(':react-native-pay-here').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-pay-here/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-pay-here')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNPayHere.sln` in `node_modules/react-native-pay-here/windows/RNPayHere.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Pay.Here.RNPayHere;` to the usings at the top of the file
  - Add `new RNPayHerePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNPayHere from 'react-native-pay-here';

// TODO: What to do with the module?
RNPayHere;
```
  