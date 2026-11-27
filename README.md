# Nómina Quincenal
# Cálculo y Registro de Nómina

> Aplicación de escritorio de Windows Forms desarrollada para calcular el pago quincenal neto de empleados aplicando tarifas por cargo, horas extra, incentivo de transporte y deducciones de ley, mostrando al final un resumen acumulado de toda la nómina.

---

## Datos del Autor
- **Nombre:** Andy Williams Rijo Báez
- **Matrícula:** 2025-0114

---

## Datos de Entrada
- **Nombre del empleado (`string`):** Nombre completo ingresado en `txtEmpleado`.
- **Tipo de contrato (`RadioButton`):** Selección entre **Fijo** (`rdbFijo`) o **Temporal** (`rdbTemporal`).
- **Cargo (`ComboBox`):** Selección entre **Auxiliar** (RD$ 180/h), **Técnico** (RD$ 250/h), **Supervisor** (RD$ 350/h) o **Gerente** (RD$ 500/h) en `cmbCargo`.
- **Horas trabajadas (`int`):** Cantidad entera de horas en la quincena (de `1` a `120`) ingresada en `txtHoras`.
- **Incentivo de transporte (`CheckBox`):** Opción `chkTransporte` para incluir o no el bono de `RD$ 1,500.00`.

---

## Datos que Procesa
- **Valida los datos ingresados:** Comprueba mediante `MessageBox` que el nombre no esté vacío, que haya un contrato y un cargo seleccionados, y que las horas sean un entero válido entre `1` y `120` usando `int.TryParse`.
- **Calcula salario regular y horas extra:** Paga hasta `88` horas a tarifa normal y las horas excedentes con un recargo del 35% (`horasExtra * tarifaHora * 1.35`).
- **Calcula el salario bruto:** Suma el salario regular, el pago de horas extra y el incentivo de transporte (`RD$ 1,500.00`) si está marcado.
- **Calcula las deducciones:** Si el contrato es **Fijo**, descuenta AFP (`2.87%`) y SFS (`3.04%`) únicamente sobre `(salarioRegular + pagoExtra)`, sin incluir el incentivo. Si es **Temporal**, las deducciones son `RD$ 0.00`.
- **Calcula el salario neto y acumuladores:** Resta las deducciones al bruto y actualiza los totales globales de empleados, bruto, deducciones y neto.

---

## Datos de Salida
- **Lista de nómina (`lstNomina`):** Agrega una línea por cada empleado registrado con el formato `Nombre · Cargo · RD$ Neto`.
- **Resumen general (`btnResumen`):** Muestra en etiquetas (`lblEmpleados`, `lblBruto`, `lblDeducciones`, `lblNeto`) la cantidad total de empleados registrados y los montos acumulados en formato `RD$` con dos decimales.

---

## Capturas de Pantalla

### Caso #1: Registro de 3 empleados y resumen general
<img width="793" height="474" alt="Captura de pantalla 2026-11-26 223100" src="https://github.com/user-attachments/assets/1895ee35-f4b4-4e6b-84a4-d449588771df" />


### Caso #2: Validación del nombre al inicio
<img width="793" height="473" alt="Captura de pantalla 2026-11-26 222958" src="https://github.com/user-attachments/assets/62b3f6bf-802f-4669-b20d-16bae0bf27ce" />


### Caso #3: Validación de la existencia de empleados
<img width="782" height="481" alt="Captura de pantalla 2026-11-26 223018" src="https://github.com/user-attachments/assets/6279dd15-3447-4968-966b-7cc92ba3b882" />

