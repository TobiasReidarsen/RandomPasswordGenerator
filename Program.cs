// user is asked to if they want a new password
// they specify the lenght of the password
// the password is returned to them

using RandomPasswordGenerator;

PasswordStore.StorePassword("Tobias", "ehehehehsshdef");
PasswordStore.StorePassword("33", "ehehedcvdfbvdfgdfhehsshdef");
PasswordStore.StorePassword("123", "45345345345");
string passwordRetrived = PasswordStore.RetrievePassword("Tobias");
Console.WriteLine(passwordRetrived);