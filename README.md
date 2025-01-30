# Taller Formativo: Aplicación de Patrones de Diseño en Sistemas de Gestión de Vehículos

## Introducción
Este proyecto tiene como propósito aplicar patrones de diseño, principios SOLID y mejores prácticas en el desarrollo de un sistema de gestión de automóviles. Su objetivo es ofrecer una solución flexible, escalable y de alta calidad que cumpla con los requisitos definidos.

Las funcionalidades clave de la aplicación incluyen:

- Métodos optimizados para el registro de nuevos vehículos.
- Un entorno de pruebas funcional sin necesidad de base de datos.
- Propiedades predefinidas en los modelos de vehículos, permitiendo adaptabilidad a futuras modificaciones.
- Implementación de un Factory Method para facilitar la creación de nuevos modelos de automóviles.

---

## Requerimientos y Problemas Detectados

### 1. Registro de vehículos
   - Los métodos actuales presentan fallos en la página principal y requieren un rediseño.
   - El patrón de repositorio empleado necesita mejoras para optimizar su rendimiento.

### 2. Falta de base de datos
   - No existe una base de datos implementada, por lo que se requiere una alternativa temporal que permita realizar pruebas sin almacenamiento persistente.

### 3. Propiedades predefinidas
   - Es necesario que cada modelo de vehículo tenga 20 propiedades preconfiguradas, incluyendo el año actual.
   - La implementación debe permitir su ampliación en futuras actualizaciones del sistema.

### 4. Incorporación de nuevos modelos
   - Se debe agregar el modelo *Escape* (marca Ford, color rojo).
   - La solución debe ser lo suficientemente flexible para permitir la creación de modelos adicionales en el futuro.


---

---

## Guía de Uso

### 1. Clonar el Repositorio
```bash
git clone https://github.com/MauroS1000/taller_formativo-main.git
```

### 2. Instalar Dependencias
```bash
dotnet restore
```

### 3. Ejecutar la Aplicación
```bash
dotnet run
```

### 4. Ejecutar Pruebas Unitarias
```bash
dotnet test
```

---

## Organización del Proyecto
- **Repositories**: Contiene la implementación del patrón Singleton para la administración de vehículos.
- **ModelBuilder**: Incluye la clase `CarModelBuilder` encargada de la construcción estructurada de modelos de automóviles.
- **Factories**: Contiene las fábricas para la creación de modelos específicos, como `FordEscapeFactory`.

---

## Consideraciones Finales
Este proyecto ha sido diseñado con un enfoque en escalabilidad y mantenibilidad. Gracias a la aplicación de principios SOLID y patrones de diseño, se garantiza un código limpio y organizado que facilita futuras expansiones y mejoras.

Agradecemos tu interés en este taller formativo. ¡Si tienes preguntas o sugerencias, no dudes en contribuir al repositorio!

