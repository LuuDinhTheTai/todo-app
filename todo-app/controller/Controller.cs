﻿using todo_app.repository;
using todo_app.service;

namespace todo_app.controller;

public class Controller
{
    public AccountRepository AccountRepository;
    public TagRepository TagRepository;
    public TodoRepository TodoRepository;

    public AccountService AccountService;
    public TagService TagService;
    public TodoService TodoService;
    public FileService FileService;

    public Form1 Form1;

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

        Form1 = new Form1(this);
    }
}