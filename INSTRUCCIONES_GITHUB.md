# 📚 Guía Completa: Visual Studio y GitHub

## 🎯 Pasos para configurar el proyecto en Visual Studio

### 1. Crear el proyecto en Visual Studio

1. **Abrir Visual Studio 2022**
2. **Crear nuevo proyecto**:
   - File → New → Project
   - Buscar "Console App"
   - Seleccionar "Console App (.NET)"
   - Click "Next"

3. **Configurar el proyecto**:
   - Project name: `TaskManager`
   - Location: Elige tu carpeta preferida
   - Framework: `.NET 6.0` o superior
   - Click "Create"

### 2. Configurar la estructura del proyecto

1. **Crear las carpetas**:
   - Click derecho en el proyecto → Add → New Folder
   - Crear: `Models`, `Services`, `UI`

2. **Agregar los archivos**:
   - Click derecho en cada carpeta → Add → Class
   - Nombrar según los archivos proporcionados

### 3. Instalar paquetes NuGet

1. **Método 1 - Package Manager Console**:
   ```
   Tools → NuGet Package Manager → Package Manager Console
   ```
   Ejecutar:
   ```powershell
   Install-Package Newtonsoft.Json
   ```

2. **Método 2 - NuGet Package Manager**:
   - Click derecho en el proyecto → Manage NuGet Packages
   - Browse → Buscar "Newtonsoft.Json"
   - Install

### 4. Copiar el código

1. **Reemplazar Program.cs** con el código proporcionado
2. **Crear cada archivo** en su carpeta correspondiente
3. **Copiar el contenido** exacto de cada archivo

## 🐙 Configuración de GitHub

### Paso 1: Preparar Git en tu máquina

1. **Instalar Git** (si no lo tienes):
   - Descargar de: https://git-scm.com/
   - Instalar con configuración por defecto

2. **Configurar Git** (primera vez):
   ```bash
   git config --global user.name "Tu Nombre"
   git config --global user.email "tu-email@ejemplo.com"
   ```

### Paso 2: Crear repositorio en GitHub

1. **Ir a GitHub.com** y hacer login
2. **Crear nuevo repositorio**:
   - Click en "New repository"
   - Repository name: `TaskManager`
   - Description: "Aplicación de gestión de tareas en C#"
   - ✅ Public (o Private si prefieres)
   - ✅ Add a README file
   - ✅ Add .gitignore → Seleccionar "Visual Studio"
   - Click "Create repository"

### Paso 3: Conectar proyecto local con GitHub

1. **Abrir terminal en Visual Studio**:
   - View → Terminal
   - O usar Git Bash en la carpeta del proyecto

2. **Inicializar Git en tu proyecto**:
   ```bash
   git init
   ```

3. **Agregar archivos al staging**:
   ```bash
   git add .
   ```

4. **Hacer el primer commit**:
   ```bash
   git commit -m "Initial commit: Task Manager application"
   ```

5. **Conectar con GitHub**:
   ```bash
   git remote add origin https://github.com/TU-USUARIO/TaskManager.git
   ```

6. **Subir el código**:
   ```bash
   git branch -M main
   git push -u origin main
   ```

## 🔧 Comandos Git esenciales para el día a día

### Comandos básicos:

```bash
# Ver estado de archivos
git status

# Agregar archivos modificados
git add .
# O agregar archivo específico
git add archivo.cs

# Hacer commit
git commit -m "Descripción de los cambios"

# Subir cambios a GitHub
git push

# Descargar cambios de GitHub
git pull

# Ver historial de commits
git log --oneline
```

### Flujo de trabajo típico:

```bash
# 1. Verificar estado
git status

# 2. Agregar cambios
git add .

# 3. Commit con mensaje descriptivo
git commit -m "Add search functionality to tasks"

# 4. Subir a GitHub
git push
```

## 🚀 Ejecutar el proyecto

### En Visual Studio:
1. **Presionar F5** o click en "Start"
2. **O usar Ctrl + F5** para ejecutar sin debug

### En terminal:
```bash
# Navegar a la carpeta del proyecto
cd ruta/a/tu/TaskManager

# Ejecutar
dotnet run
```

## 🐛 Solución de problemas comunes

### Error: "Package not found"
```bash
# Restaurar paquetes NuGet
dotnet restore
```

### Error: "Git not recognized"
- Reiniciar Visual Studio después de instalar Git
- Verificar que Git esté en el PATH del sistema

### Error: "Remote origin already exists"
```bash
# Remover origin existente
git remote remove origin
# Agregar el correcto
git remote add origin https://github.com/TU-USUARIO/TaskManager.git
```

### Error de autenticación en GitHub:
1. **Usar Personal Access Token**:
   - GitHub → Settings → Developer settings → Personal access tokens
   - Generate new token (classic)
   - Seleccionar scopes: repo, workflow
   - Usar el token como contraseña

## 📋 Checklist final

- [ ] Proyecto creado en Visual Studio
- [ ] Estructura de carpetas correcta
- [ ] Todos los archivos copiados
- [ ] Paquete Newtonsoft.Json instalado
- [ ] Proyecto compila sin errores (F5)
- [ ] Repositorio creado en GitHub
- [ ] Git configurado localmente
- [ ] Código subido a GitHub
- [ ] README.md actualizado

## 🎉 ¡Listo!

Tu aplicación de gestión de tareas está lista y en GitHub. Ahora puedes:
- Hacer cambios y subirlos con git
- Compartir el repositorio
- Colaborar con otros desarrolladores
- Usar GitHub como respaldo de tu código

¿Necesitas ayuda con algún paso específico? ¡Pregúntame!