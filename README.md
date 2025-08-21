# Agora

🏛️ Ágora — Plataforma de Gestión de Capacitaciones

Ágora es un proyecto educativo desarrollado junto a estudiantes de 2.º año de Programación. Su objetivo es brindar una plataforma integral para gestionar capacitaciones de una institución educativa: desde la publicación y la inscripción (online/presencial), hasta la acreditación, cobros y emisión de certificados.

📌 Objetivo del proyecto

Construir un sistema claro, ágil y auditable que permita organizar capacitaciones y sus participantes, ofreciendo:

Un flujo simple de inscripción (para público general, docentes y alumnos).

Control de cupos, costos diferenciados por tipo de inscripción y habilitación/deshabilitación de inscripciones.

Acreditación de asistencia y registro de pagos con reportes e impresión de certificados (individual y masiva).

Reportes operativos para mesa de acreditación y administración.

🗂️ Índice

Objetivo del proyecto

Alcance y funcionalidades

Roles y reglas generales

Flujos principales

Entidades clave

Reportes e impresiones

Hoja de ruta (Roadmap)

Estructura del repositorio (sugerida)

Cómo contribuir

Licencia

✅ Alcance y funcionalidades

A continuación se detallan los requerimientos funcionales priorizados para la primera versión:

📚 Capacitaciones

Alta, modificación y eliminación de capacitaciones.

Habilitar/Deshabilitar la inscripción por capacitación.

Definir cupo máximo.

Definir costos por tipo de inscripción: público general, docentes y alumnos.

👤 Usuarios

Alta, modificación y eliminación de usuarios.

💻 Inscripción online

Inscribirse a una capacitación disponible.

La inscripción se desactiva automáticamente al completar el cupo máximo.

(Futuro) Carga de comprobante de transferencia para acreditar pago; validación por un usuario autorizado.

🏫 Inscripción presencial

Registro manual por personal autorizado.

✅ Acreditación de asistencia

Marcado de asistencia para cada inscripto.

📜 Certificados

Impresión de certificados para acreditados que abonaron (si aplica).

Impresión masiva por capacitación e individual por asistente.

Si la capacitación no tiene costo, se imprime a todo acreditado.

Rol administrativo puede imprimir a todos (pago contra entrega).

💰 Pagos

Pantalla específica para registración de pagos (monto, medio, fecha, observaciones).

📝 Listado de inscriptos

Impresión de inscriptos por capacitación (para mesa de acreditación manual).

📄 Listado de acreditados

Impresión con detalle de si pagaron y forma de pago.

💵 Reporte de cobros

Impresión de cobros por usuario y por capacitación, con detalle y totales por forma de pago.

🧑‍🤝‍🧑 Roles y reglas generales

Público en general / Docente / Alumno: puede inscribirse online cuando esté habilitado y existan cupos.

Administrativo: puede gestionar inscripciones presenciales, registrar pagos, acreditar asistencia y emitir certificados (individual/masivo).

Reglas destacadas:

La inscripción depende de habilitación y cupo.

La emisión de certificados requiere asistencia acreditada y, si corresponde, pago registrado.

🔁 Flujos principales

Publicar capacitación

Crear capacitación → 2) Definir cupo y costos → 3) Habilitar inscripciones.

Inscripción online

Usuario elige capacitación → 2) Completa datos → 3) Sistema valida cupo → 4) Registro de inscripción.

Inscripción presencial

Administrativo busca o crea usuario → 2) Registra inscripción → 3) Entrega comprobante.

Acreditación de asistencia

Lista de inscriptos → 2) Marcar presente/ausente → 3) Guardar acreditación.

Registro de pagos

Seleccionar inscripto → 2) Registrar medio/monto/fecha → 3) Asociar a capacitación.

Emisión de certificados

Individual: verificar requisitos → generar e imprimir.

Masivo: filtrar por capacitación → validar requisitos → imprimir lote.

🧱 Entidades clave
Entidad	Descripción breve
Capacitación	Título, descripción, fechas, cupo máximo, estado de inscripción (habilitada/inhabilitada), costos por tipo.
Usuario	Datos personales, tipo: público, docente, alumno, administrativo.
Inscripción	Usuario ↔ Capacitación, estado (activa/cancelada), origen (online/presencial).
Asistencia	Registro por inscrito (acreditado / no acreditado).
Pago	Monto, forma de pago, fecha, referencia (comprobante), vinculado a Inscripción/Capacitación.
Certificado	Emisión individual/masiva para acreditados (y con pago si corresponde).
🖨️ Reportes e impresiones

Inscriptos por capacitación (para mesa de acreditación).

Acreditados por capacitación con estado de pago y forma de pago.

Cobros por usuario y capacitación, con detalles y totales por forma de pago.

Certificados: emisión individual y masiva.

🗺️ Hoja de ruta (Roadmap)

 MVP: ABM de capacitaciones y usuarios, inscripción online/presencial, acreditación, pagos, reportes básicos y emisión de certificados.

 Evidencia de pago (3.2): carga de imagen de transferencia + circuito de validación por administrativo.

 Mejoras UX: filtros avanzados, búsqueda rápida, exportación a CSV/PDF.

 Permisos granulares por rol y auditoría de acciones.

 Notificaciones (email/whatsapp) para confirmaciones y recordatorios.

📁 Estructura del repositorio (sugerida)
/docs/                 # Documentación funcional/técnica, decisiones y diagramas
/frontend/             # App web (por definir stack)
 /...                  
/backend/              # API/servicios (por definir stack)
 /...                  
/infrastructure/       # Scripts de despliegue, Docker, CI/CD
/.github/workflows/    # Pipelines (si corresponde)
README.md
LICENSE


💡 Sugerencia didáctica: mantener en /docs la trazabilidad entre requerimientos y pantallas/endpoints, y anotar decisiones (ADR) para aprender de la arquitectura del proyecto.

🤝 Cómo contribuir

Crea una rama con el formato feature/descripcion-corta o fix/descripcion-corta.

Acompaña tus cambios con descripción clara y, cuando aplique, capturas o gif.

Relaciona tu PR con el requerimiento funcional correspondiente (ej.: “RF-6 Certificados”).

Pide code review a otro/a compañero/a y a la cátedra antes de mergear.

Mantén el estilo de código consistente y agrega tests cuando sea posible.

📜 Licencia

Este proyecto se distribuye bajo la licencia MIT (o la que la cátedra defina). Incluye el archivo LICENSE en el repositorio.

✉️ Contacto

Proyecto Ágora — 2.º Año Programación
Si tenés dudas, sugerencias o encontrás un bug, abrí un Issue y describí claramente el caso.

“Lo que no se mide, no se mejora.” — Ágora prioriza la claridad operativa y la trazabilidad para que cada decisión y funcionalidad se pueda enseñar, aprender y evolucionar.
