# Working with energy consumption and meter data
This is a small C# project that contains functions with empty logic: implement the logic in the functions and write _unit tests_ for the various use cases. Add comments whenever you deem it necessary, either in the code or via a separate readme file.

## Input data
In the `src/MeterData` folder there are two CSV files, each containing meter data for an electricity meter. Please note that
* the values are _consumption values_, i.e. the amount of electricity used during the 15-minute interval starting at the timestamp.
* the values are assumed to be expressed in kWh
* the timestamps are in local time including the UTC offset (according to the ISO8601 date notation). 

## Requirements
Please create a program in C# that:
* reads the data from the CSV files
* calculates the following information (see also details below):
  * the total energy consumption for each month, for each meter, in kWh
  * the energy consumption split out in 'day' and 'night' consumption (see below for what this means) for each month, for each meter, in kWh
  * the peak energy demand (a.k.a. 'maximum demand') for each month, for each meter, in kW (!!)
  * outputs the results in a clear table showing the requested information above. This may be to a file, to a window or to the console. 

## Additional information
* energy consumption during the 'day' is Monday - Friday, between 07:00 - 22:59 (inclusive, local time)
* energy consumption during the 'night' is everything that is not 'day'
* the files may contain some data outside 2020, please exclude those values from your results
* since this is actual data, there may be gaps in the data. You can assume there was no consumption in those intervals
* please make sure to understand the difference between kW and kWh (ask Google!)
* we will look at clean and good readable coding, correct use of objects and/or functions, and the use of documentation/comments
* a minimal NUnit test project is already set up for you. However, if you are more comfortable with other test frameworks, feel free to add your own. For an intro to NUnit, see https://docs.nunit.org/
* the provided code is just a template. It is up to you to shape it so that the requirements are met.

Here is an example of the structure of the output (note that formatting is not the most important thing here, a plain-text table to the console is perfectly fine):

![image](https://user-images.githubusercontent.com/5672785/152315456-5e6b92a1-1e3d-46be-9729-404f4f36735a.png)
