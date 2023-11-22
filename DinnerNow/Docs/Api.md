# Dinner Now API

- [Dinner Now API](#dinner-now-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)



## Auth

### Register

 ```js
POST {{host}}/auth/register
```
#### Register Request
```json
{
    "firstName" : "Jeffrey",
    "lastName" : "Kolenchery",
    "email" : "jeffrey@kolenchery.com",
    "password" : "8943uiower934"

}
```

#### Register Response
```json
{
    "id" : "welivbegsur-vuret434-hoerf78rf-eriuhf34",
    "firstName" : "Jeffrey",
    "lastName" : "Kolenchery",
    "email" : "jeffrey@kolenchery.com",
    "token" : "eby..hbbQ"

}
```

### Login

 ```js
POST {{host}}/auth/login
```
#### Login Request
```json
{
    "email" : "jeffrey@kolenchery.com",
    "password" : "8943uiower934"

}
```

#### Login Response
```json
{
    "id" : "welivbegsur-vuret434-hoerf78rf-eriuhf34",
    "firstName" : "Jeffrey",
    "lastName" : "Kolenchery",
    "email" : "jeffrey@kolenchery.com",
    "token" : "eby..hbbQ"

}
```