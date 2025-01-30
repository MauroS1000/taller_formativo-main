# Taller Formativo: Implementación de Patrones de Diseño en Aplicaciones de Gestión de Automóviles

## Descripción General
Este proyecto tiene como objetivo implementar patrones de diseño, principios SOLID y mejores prácticas en un sistema de gestión de vehículos. La finalidad es cumplir con los requerimientos definidos para garantizar una solución escalable y de alta calidad.

En esta aplicación, se incluyen las siguientes funcionalidades clave:

- Métodos para agregar vehículos de forma eficiente.
- Un entorno de prueba independiente de la base de datos.
- Propiedades por defecto para vehículos, optimizando la capacidad de adaptación a futuros cambios.
- Un Factory Method para la creación dinámica de nuevos modelos de vehículos.

---

## Requerimientos del Proyecto

### Problemas Identificados
1. **Métodos de agregar vehículos**:
   - Los métodos actuales en la página principal no funcionan correctamente y necesitan ser rediseñados.
   - El patrón de repositorio utilizado requiere ajustes para mejorar su funcionalidad.

2. **Ausencia de base de datos**:
   - Actualmente no hay un esquema de base de datos disponible, por lo que se necesita una solución temporal que permita realizar pruebas sin almacenamiento persistente.

3. **Propiedades por defecto**:
   - Es necesario que el modelo de vehículo incluya 20 propiedades por defecto, además del año actual.
   - La implementación debe ser extensible para facilitar cambios en futuros sprints.

4. **Adición de nuevos modelos de vehículos**:
   - Se solicita la incorporación de un nuevo modelo: Escape (marca Ford, color rojo).
   - La solución debe ser lo suficientemente flexible para soportar la creación de futuros modelos.

---

## Solución Propuesta
Para abordar los problemas identificados, se implementaron los siguientes patrones de diseño:

### 1. **Patrón Singleton**
- **Propósito**: Proveer un repositorio temporal único para gestionar vehículos mientras se desarrolla la base de datos.
- **Implementación**: Se creó la clase `MyVehiclesRepository` dentro de la carpeta `Repositories`.

### 2. **Patrón Builder**
- **Propósito**: Simplificar la construcción de vehículos con propiedades por defecto, incluyendo el año actual.
- **Implementación**: Se desarrolló la clase `CarModelBuilder` ubicada en la carpeta `ModelBuilder`.

### 3. **Patrón Factory Method**
- **Propósito**: Estandarizar y simplificar la creación de nuevos modelos de vehículos.
- **Implementación**: Se añadieron las clases `FordEscapeFactory`, `FordExplorerFactory` y `FordMustangFactory` en la carpeta `Factories`.

---

## Justificación de los Patrones Utilizados
- **Builder**: Este patrón permite manejar de manera flexible y extensible las propiedades por defecto de los vehículos, facilitando modificaciones futuras.
- **Factory Method**: Asegura que la creación de nuevos modelos siga un proceso estándar, reduciendo la complejidad del código.
- **Singleton**: Brinda una solución temporal para el manejo de datos sin duplicar instancias, ideal para suplir la falta de una base de datos en esta etapa.

---

## Pasos para Ejecutar el Proyecto

### 1. Clonar el Repositorio
```bash
git clone https://github.com/EmilioAMVs/Taller_Formativo_Mejores_Practicas.git
cd Taller_Formativo_Mejores_Practicas
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

## Estructura del Proyecto
- **Repositories**: Contiene la implementación del patrón Singleton para el repositorio de vehículos.
- **ModelBuilder**: Incluye la clase `CarModelBuilder` para la construcción flexible de vehículos.
- **Factories**: Define las fábricas específicas para la creación de modelos de vehículos, como `FordEscapeFactory`.

---

## Notas Adicionales
Este proyecto está diseñado para ser fácilmente escalable y adaptable a futuros cambios. Al implementar principios SOLID y patrones de diseño, se garantiza un código limpio y mantenible.

¡Gracias por explorar este taller formativo! Si tienes alguna pregunta o sugerencia, no dudes en contribuir al repositorio.
