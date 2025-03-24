# AkenoX API (ASP.NET Core)

AkenoX API is a high-performance web API built with **ASP.NET Core**. It provides ultra-fast responses, making it ideal for high-load applications.

## 🚀 Features

- **⚡ High Performance:** Runs on **ASP.NET Core**, optimized for speed and efficiency.
- **📡 RESTful API:** Supports **GET** and **POST** requests with JSON responses.
- **🔗 External API Integration:** Fetches data from external sources.
- **📄 Swagger UI:** Interactive API documentation available.
- **🔒 Secure:** Built-in **HTTPS redirection** and middleware.
- **📦 Docker Support:** Easily deployable using Docker.

## 📥 Installation

### 1️⃣ Prerequisites
- .NET SDK **8.0+**
- Docker (optional, for containerization)

### 2️⃣ Clone the Repository
```sh
 git clone https://github.com/xtsea/akenox-net.git
 cd akenox-net
```

### 3️⃣ Install Dependencies
```sh
dotnet restore
```

### 4️⃣ Run the API
```sh
dotnet run
```

## 🛠 API Endpoints

| Method | Endpoint | Description |
|--------|------------|-------------|
| **GET** | `/api/dev/endpoint` | Fetch data from external API |
| **GET** | `/api/dev/instagram-dl?url=<url>` | Download media from Instagram |
| **GET** | `/swagger` | Open API documentation |

## 🐳 Docker Deployment

### Build and Run with Docker
```sh
docker build -t akenox-api .
docker run -d -p 8501:8501 akenox-api
```

## 🔗 Live Demo
> **Try it now:** [AkenoX API](https://akenox-net.onrender.com/swagger/index.html)

## 📜 License
MIT License. Free to use and modify.

---

💡 **Contributors Welcome!** Feel free to fork and contribute.

