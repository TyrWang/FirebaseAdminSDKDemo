// See https://aka.ms/new-console-template for more information
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;

Console.WriteLine("Sending test notification to a given device token: ");
var registrationToken = Console.ReadLine() ?? "YOUR_REGISTRATION_TOKEN";

try
{
	FirebaseApp.Create(new AppOptions()
	{
		Credential = GoogleCredential.FromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "secrets/fir-firebase-adminsdk.json")),
	});
	Console.WriteLine("logged in...");

	var message = new Message()
	{
		Notification = new Notification()
		{
			Title = "FCM Message",
			Body = "This is an FCM notification message!",
		},
		Token = registrationToken,
	};
	string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
	Console.WriteLine("Notification sent. ");
}
catch (Exception ex)
{
	Console.WriteLine(ex.ToString());
}
