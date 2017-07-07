# SimSinter
**SimSinter for Aspen 7.3.2 or greater** Simulation interface for connecting Aspen Plus or ACM simulations to FOQUS and Turbine Gateway. Includes SinterConfigGUI.

## Development Practices

* Code development will be peformed in a forked copy of the repo. Commits will not be 
  made directly to the ngt-archive repo. Developers will submit a pull 
  request that is then merged by another team member, if another team member is available.
* Each pull request should contain only related modifications to a feature or bug fix.  
* Sensitive information (secret keys, usernames etc) and configuration data 
  (e.g database host port) should not be checked in to the repo.
* A practice of rebasing with the main repo should be used rather that merge commmits.

## Getting Started
This software has been compiled and tested on Windows 7 professional

### Pre-requisites
Your environment must have the following tools installed.
The build has be tested with the following versions. Use other
versions at your own risk.

+ Git Bash for windows
+ CMake 3.9
+ Microsoft Visual Studio 11.0
+ Microsoft .NET v4.0.30319
+ Wix Toolset v3.10

### Build and Test
After installing the tools above run the Git Bash program.
Executing the commands below with compile the source and 
run the tests.


```
git clone https://github.com/CCSI-Toolset/SimSinter.git
cd SimSinter
start make.bat

```

## Authors

* Jim Leek

See also the list of [contributors](https://github.com/CCSI-Toolset/SimSinter/contributors) who participated in this project.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, 
see the [tags on this repository](https://github.com/CCSI-Toolset/SimSinter/tags). 

## License

See [LICENSE.md](LICENSE.md) file for details

## Copyright Notice

TBD
