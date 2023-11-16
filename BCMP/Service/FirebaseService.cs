using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BCMP.Service
{
    public class FirebaseService
    {
        private static string ApiKey = "AIzaSyB2jJdUU5aYKKowC6sEbvCGHE1Tpx8T6go";
        private static string Bucket = "hans-shop.appspot.com";
        private static string AuthEmail = "storage@bcmp.example.com";
        private static string AuthPassword = "BCMP.CNPM";

        public async Task<string> UploadFileToStorage(FileStream stream, string filename)
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);


            var cancellation = new CancellationTokenSource();

            var task = new FirebaseStorage(Bucket, new FirebaseStorageOptions()
            {
                AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                ThrowOnCancel = true
            }).Child(DateTime.Now.ToString("MM-dd-yyyy-h:mm-tt") + "-" + filename).PutAsync(stream, cancellation.Token);

            return await task;
        }
    }
}
