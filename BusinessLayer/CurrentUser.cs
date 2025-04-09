using BusinessLayer;

public class GlobalUser
{
    private static GlobalUser _instance;
    private static readonly object _lock = new object();

    public clsUser LoggedInUser { get; set; }

    private GlobalUser() { }

    public static GlobalUser Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new GlobalUser();
                return _instance;
            }
        }
    }

    public bool IsLoggedIn => LoggedInUser != null;

    public void Logout()
    {
        LoggedInUser = null;
    }
}
