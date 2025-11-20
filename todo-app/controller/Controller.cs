using todo_app.repository;
using todo_app.service;
using todo_app.view;

namespace todo_app.controller
{
    public AccountRepository AccountRepository;
    public TagRepository TagRepository;
    public TodoRepository TodoRepository;

    public AccountService AccountService;
    public TagService TagService;
    public TodoService TodoService;
    public FileService FileService;
    public ChartService ChartService;
    public RememberMeService RememberMeService;

    public MainForm MainForm;
    public LoginForm LoginForm;
    public RegisterForm RegisterForm;

    public LoggedInAccount LoggedInAccount;
    
    public void Init()
    {
        LoggedInAccount = new LoggedInAccount();
        
        AccountRepository = new AccountRepository();
        TagRepository = new TagRepository();
        TodoRepository = new TodoRepository();

        AccountService = new AccountService(this);
        TagService = new TagService(this);
        TodoService = new TodoService(this);
        FileService = new FileService(this);
        ChartService = new ChartService(this);
        RememberMeService = new RememberMeService();

        MainForm = new MainForm(this);
        LoginForm = new LoginForm(this);
        RegisterForm = new RegisterForm(this);
    }
}
