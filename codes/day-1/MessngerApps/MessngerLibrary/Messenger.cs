namespace MessngerLibrary
{
    /// <summary>
    /// Messenger class
    /// </summary>
    public class Messenger
    {
        /// <summary>
        /// the method to display a message
        /// </summary>
        /// <param name="name">
        /// name of a person
        /// </param>
        /// <returns>
        /// returns a string (message)
        /// </returns>
        public string ShowMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
