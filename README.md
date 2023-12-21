# FirebaseAdminSDKDemo
Firebase Admin SDK 的簡單 poc
## How to USE
#### Authorize on a non-Google server environment
1. In the Firebase console, open Settings > [Service Accounts](https://console.firebase.google.com/project/_/settings/serviceaccounts/adminsdk?_gl=1*q6fwu9*_ga*MTg4MjE5NjU0My4xNzAxNzU4NzM2*_ga_CW55HF8NVT*MTcwMzEzODMwMS4zOS4xLjE3MDMxNDUxNjAuNTcuMC4w). 
2. Click Generate New Private Key, then confirm by clicking Generate Key. 
3. Securely store the JSON file containing the key. 
4. Put and rename the JSON file at "{UserDirectory}/secrets/fir-firebase-adminsdk.json". 
5. Run the app. 
