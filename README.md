# DI_example
Dependency Injection example in Blazor ( .NET5) with comment



[TOC]

# 간단한 DI(Dependency Injection)의 이해

생성자 주입을 경험해보고자 한다. 순서는 아래와 같다.

코드는 Github에 첨부되어있다.

## {ProjectName}.Shared

1. [User.cs 생성](https://github.com/dhddldid/DI_example/blob/master/DI_example/Shared/User.cs)

## {ProjectName}.Server

1. [Services/IUserRepository.cs 생성](https://github.com/dhddldid/DI_example/blob/master/DI_example/Server/Services/IUserRepository.cs)
2. [Services/UserRepository.cs 생성](https://github.com/dhddldid/DI_example/blob/master/DI_example/Server/Services/UserRepository.cs)
3. [Controller/HomeController.cs](https://github.com/dhddldid/DI_example/blob/master/DI_example/Server/Controller/HomeController.cs) 에서 메서드 추가 이곳에서 생성자 주입이 이루어진다.
4. [Startup.cs](https://github.com/dhddldid/DI_example/blob/master/DI_example/Server/Startup.cs) 에서 ConfigureServices에서 서비스 추가 (ConfigureServices 서비스 컨테이너에 추가하는 것)

## {ProjectName}.Client

[Pages/Index.razor](https://github.com/dhddldid/DI_example/blob/master/DI_example/Client/Pages/Index.razor) 에서 

메서드 추가  Controller 와 통신
