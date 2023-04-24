# Devacore Humaxoo API

- [Devacore Humaxoo API](#devacore-humaxoo-api)
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
POST {{host}}/api/auth/register
```

#### Register Request

```json
{
  "firstName": "Nader",
  "lastName": "Laroussi",
  "email": "nader.laroussi@gmail.com",
  "phoneNumber": "+33659988542",
  "country": "FR",
  "companyName": "Humaxoo",
  "companySize": "BTW_10_20"
}
```

#### Register Response

```js
204 NoContent
```

### Login

```js
POST {{host}}/api/auth/login
```

#### Login Request

```json
{
  "email": "nader.laroussi@gmail.com",
  "password": "Zayd2017#"
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "624d17e46f5c5f5db5a5c892",
  "subscriptionId": "624d17e46f5c5f5db5a5c893",
  "defaultAgencyId": "624d17e46f5c5f5db5a5c894",
  "firstName": "Nader",
  "lastName": "Laroussi",
  "email": "nader.laroussi@gmail.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.NK6rYdYiJU6f_SGwwHKmfO6Ml0vzKjGLlSkkexz7RFI"
}
```
