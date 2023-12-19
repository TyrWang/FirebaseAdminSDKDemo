// See https://aka.ms/new-console-template for more information
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

Console.WriteLine("Hello, World!");

var defaultApp = FirebaseApp.Create(new AppOptions()
{
	Credential = GoogleCredential.FromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "secrets/fir-firebase-adminsdk.json")),
});

Console.WriteLine(defaultApp.Name);