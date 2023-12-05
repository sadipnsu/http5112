# SeasonApp

This application will take an input of the temperature and output a webpage associated with the season. You can run the project by clicking F5 on your computer or the green play button.

Key Files in this Project:
- Models/Season.cs. A class which holds information about a season, including the season name and associated image.
- Controllers/SeasonAPIController.cs. The main logic webapi controller. Inputs a temperature and outputs a season object.
- Controllers/SeasonController.cs. Controller which connects to views. Receives temperature data and presents a webpage for the season.
- Views/Season/Index.cshtml. A view which creates a webpage that asks the user for the temperature.
- Views/Season/Show.cshtml. A view which creates a webpage that shows the season image and season name. 
- Views/Shared/\_Layout.cshtml. A special view which describes a general header HTML and footer HTML. 

Videos Associated with this project:
- [Learning C# For Web Development Pt6](https://www.youtube.com/watch?v=LtUtbXfPQI0&feature=youtu.be)
- [Learning C# For Web Development Pt7](https://www.youtube.com/watch?v=pmvf7DMOgLk&feature=youtu.be)
- [Learning C# For Web Development Pt8](https://www.youtube.com/watch?v=AjluOmFRPME&feature=youtu.be)
- [Learning C# For Web Development Pt9](https://www.youtube.com/watch?v=yu59Owd85bM&feature=youtu.be)
- [Learning C# For Web Development Pt10](https://www.youtube.com/watch?v=D0CzWSE1fDw&feature=youtu.be)

![Diagram Depicting the flow of information](https://github.com/christinebittle/SeasonApp/blob/master/SeasonApp/Content/images/server_rendered_pages.png)

[Client side codebase for accessing this webapi method can be found here](https://github.com/christinebittle/seasonapp_xhr)
