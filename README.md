# Vigilant Coding Exercise
This exercise is a practical exploration of MAUI coding.
We want to quickly step through common tasks in setting up a project from the ground up.

## Exercise Goals
These are the goals:
Establish a new .NET MAUI project targeting iOS/Android and Windows if supported on your dev machine.

You will need to add the following package to your project:
PackageReference Include="GeoJSON.Text" Version="1.1.0" 
  
A data file is included in this directory as well as a Datastore definition and object definition for that data file.
put the file in raw resources, use FileSystem.OpenAppPackageFileAsync("Intel.json")

The objects in the data store use camelCase, accomodate the JSON read using one of:
  * new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
  * [JsonProperty("...")] annotation
  * rename property
mechanism

Create a reader for that file that will read out 100 data items at a time with an interface, added to the DI container as a singleton.
Create a scrolling collection view to display those results with the summary information and PublishedAt time.
Provide a means to click on member of the list and view the full contents of that item.

from page in Maui Shell, Navigation.PushAsync(new DetailsPage());
Shell.Current.GoToAsync("//animals/monkeys");
or other...

Demonstrate functionality on test device.
Create branch, push to dev branch or create a PR to dev branch.

## Additional Items as Time Permits
Provide logging via any provider.  Log debug and verbose items.  Bonus, provide logger using Microsoft ILogger<X> interface.
Request permissions for device location use.
Create a test case, mock the data interface.
Given a JWT and url, provide a http client with bearer token to pull the data from the dev API.

