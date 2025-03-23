using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow;

string userName = Helpers.GetName();

menu.MainMenu(userName, date);