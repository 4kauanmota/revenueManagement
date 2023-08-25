![Project Stars](https://img.shields.io/github/stars/4kauanmota/revenueManagement?color=1e90ff) ![Project Commits Week](https://img.shields.io/github/commit-activity/w/4kauanmota/revenueManagement?color=1e90ff)

# 📄 **Informations**
**This project was made for a university challenge, the topic is about create a site using [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/) with [WEB ASSEMBLY](https://webassembly.org/)**

---

# ✨ **Features**
+ CRUD
  + Recipe
  + Ingredient
+ Api creation
+ Api fetch
+ Image management
+ Animated icons

---

# 💻 **Technologies**
+ [HTML](https://developer.mozilla.org/pt-BR/docs/Web/HTML)
+ [CSS](https://developer.mozilla.org/pt-BR/docs/Web/CSS)
+ [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/)
+ [.NET](https://dotnet.microsoft.com/pt-br/)
+ [BLAZOR](https://dotnet.microsoft.com/pt-br/apps/aspnet/web-apps/blazor)
+ [WEB ASSEMBLY](https://webassembly.org/)
+ [RAZOR](https://learn.microsoft.com/pt-br/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio)
+ [MYSQL](https://www.mysql.com/)
+ [MYSQL WORKBENCH](https://www.mysql.com/products/workbench/)
+ [DBEAVER](https://dbeaver.io/download/)

---

# ⚙️ **How to run**
### Requirements
+ [GIT](https://git-scm.com/)
+ [.NET](https://dotnet.microsoft.com/pt-br/download)
+ [MYSQL WORKBENCH](https://www.mysql.com/products/workbench/)

### Codes
+ `git clone https://github.com/4kauanmota/revenueManagement .`
+ `dotnet run --project CadastroFoodApi`
+ `dotnet run --project CadastroFoodWasm`

#### Cloning project
First you will need to open the terminal in the folder where you want to clone this project, and then, you paste this code 
```
git clone https://github.com/4kauanmota/revenueManagement .
```

#### Creating database
In [MYSQL WORKBENCH](https://www.mysql.com/products/workbench/) you will paste this command to create project database
```
create table food ( Id varchar(100) null, Name varchar(100) null, Description varchar(255) null, Weight double null, Time double null, Preparation varchar(100) null );

create table food_ingredient ( Id varchar(100) null, IdFood varchar(100) null, IdIngredient varchar(100) null );

create table ingredient ( Id varchar(100) null, Name varchar(80) null, Weight double null );
```
You can modify connection settings in CadastroFoodApi > DAOs > AutoDAO.cs. But, if you don't want that, you will need to create a database user with this informations: `user: aluno` `password: aluno` in a database named `icomida`

#### Running project
To run the project you just need to enter this command in the project terminal
```
dotnet run --project CadastroFoodApi
dotnet run --project CadastroFoodWasm
```

---

# 👀 **Preview**
### Desktop
![Preview Computer](https://i.postimg.cc/85CH4JNh/webass.gif)

---

# 📝 **Authors**
[Kauan Soares Mota](https://github.com/4kauanmota) <br>
[Johnnick F. Landim](https://github.com/johnnickjf)
