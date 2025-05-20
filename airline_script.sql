DROP DATABASE IF EXISTS AIRLINE_DB;
CREATE DATABASE AIRLINE_DB;
USE AIRLINE_DB;

-- USERS MANAGEMENT
CREATE TABLE COUNTRIES (
    country_id INT PRIMARY KEY AUTO_INCREMENT,
    iso_code VARCHAR(2) UNIQUE NOT NULL,
    name VARCHAR(100) NOT NULL,
    is_active BOOLEAN NOT NULL
);

CREATE TABLE DOCUMENT_TYPES (
    document_type_id INT PRIMARY KEY AUTO_INCREMENT,
    type_code VARCHAR(20) UNIQUE NOT NULL,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE ROLES (
    role_id INT PRIMARY KEY AUTO_INCREMENT,
    code VARCHAR(20) UNIQUE NOT NULL,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(255)
);

CREATE TABLE CONTRACTS_STATUSES (
    contract_status_id INT PRIMARY KEY AUTO_INCREMENT,
    type_code VARCHAR(20) UNIQUE NOT NULL,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE USERS (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    document_type_id INT NOT NULL,
    country_id INT NOT NULL,
    role_id INT NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    first_name VARCHAR(100) NOT NULL,
    second_name VARCHAR(100),
    first_last_name VARCHAR(100) NOT NULL,
    second_last_name VARCHAR(100),
    phone_number VARCHAR(20) NOT NULL,
    address VARCHAR(255) NOT NULL,
    birth_date DATE NOT NULL,
    training_institution VARCHAR(100),
    education_level VARCHAR(50),
    degree_title VARCHAR(100),
    residence_country_id INT,
    birth_country_id INT,
    contract_status_id INT,
    username VARCHAR(100) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    is_active BOOLEAN NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (document_type_id) REFERENCES DOCUMENT_TYPES(document_type_id),
    FOREIGN KEY (country_id) REFERENCES COUNTRIES(country_id),
    FOREIGN KEY (role_id) REFERENCES ROLES(role_id),
    FOREIGN KEY (residence_country_id) REFERENCES COUNTRIES(country_id),
    FOREIGN KEY (birth_country_id) REFERENCES COUNTRIES(country_id),
    FOREIGN KEY (contract_status_id) REFERENCES CONTRACTS_STATUSES(contract_status_id)
);

-- TICKETS MANAGEMENT
CREATE TABLE CITIES (
    city_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    is_active BOOLEAN NOT NULL
);

CREATE TABLE AIRPLANES_STATUSES (
    airplane_status_id INT PRIMARY KEY AUTO_INCREMENT,
    status_code VARCHAR(20) UNIQUE NOT NULL,
    status_name VARCHAR(50) NOT NULL,
    status_description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE AIRPLANES (
    registration_number VARCHAR(20) PRIMARY KEY,
    airplane_status_id INT,
    passenger_capacity INT NOT NULL,
    manufacturer VARCHAR(50) NOT NULL,
    model VARCHAR(100) NOT NULL,
    acquisition_date DATETIME NOT NULL,
    FOREIGN KEY (airplane_status_id) REFERENCES AIRPLANES_STATUSES(airplane_status_id)
);

CREATE TABLE ROUTES (
    route_id INT PRIMARY KEY AUTO_INCREMENT,
    origin_city_id INT,
    destination_city_id INT,
    FOREIGN KEY (origin_city_id) REFERENCES CITIES(city_id),
    FOREIGN KEY (destination_city_id) REFERENCES CITIES(city_id)
);

CREATE TABLE LAYOVERS (
    layover_id INT PRIMARY KEY AUTO_INCREMENT,
    route_id INT,
    city_id INT,
    stop_order INT NOT NULL,
    scheduled_arrival_time DATETIME NOT NULL,
    scheduled_departure_time DATETIME NOT NULL,
    layover_duration TIME NOT NULL,
    FOREIGN KEY (route_id) REFERENCES ROUTES(route_id),
    FOREIGN KEY (city_id) REFERENCES CITIES(city_id)
);

CREATE TABLE FLIGHT_STATUSES (
    flight_status_id INT PRIMARY KEY AUTO_INCREMENT,
    status_code VARCHAR(20) UNIQUE NOT NULL,
    status_name VARCHAR(50) NOT NULL,
    status_description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE FLIGHTS (
    flight_id INT PRIMARY KEY AUTO_INCREMENT,
    airplane_id VARCHAR(20),
    route_id INT,
    flight_status_id INT,
    departure_time DATETIME NOT NULL,
    arrival_time DATETIME NOT NULL,
    FOREIGN KEY (airplane_id) REFERENCES AIRPLANES(registration_number),
    FOREIGN KEY (route_id) REFERENCES ROUTES(route_id),
    FOREIGN KEY (flight_status_id) REFERENCES FLIGHT_STATUSES(flight_status_id)
);

CREATE TABLE EMPLOYEES_FLIGHTS (
    employee_id INT,
    flight_id INT,
    PRIMARY KEY (employee_id, flight_id),
    FOREIGN KEY (employee_id) REFERENCES USERS(user_id),
    FOREIGN KEY (flight_id) REFERENCES FLIGHTS(flight_id)
);

CREATE TABLE TICKET_STATUSES (
    ticket_status_id INT PRIMARY KEY AUTO_INCREMENT,
    status_code VARCHAR(20) UNIQUE NOT NULL,
    status_name VARCHAR(50) NOT NULL,
    status_description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE TICKETS (
    ticket_id INT PRIMARY KEY AUTO_INCREMENT,
    customer_id INT,
    flight_id INT,
    ticket_status_id INT,
    price DECIMAL(10,2) NOT NULL,
    assigned_seat VARCHAR(10) NOT NULL,
    sale_date DATETIME NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES USERS(user_id),
    FOREIGN KEY (flight_id) REFERENCES FLIGHTS(flight_id),
    FOREIGN KEY (ticket_status_id) REFERENCES TICKET_STATUSES(ticket_status_id)
);

CREATE TABLE LUGGAGES_TYPES (
    luggage_type_id INT PRIMARY KEY AUTO_INCREMENT,
    type_code VARCHAR(20) UNIQUE NOT NULL,
    name VARCHAR(80) NOT NULL,
    description VARCHAR(255),
    is_active BOOLEAN NOT NULL
);

CREATE TABLE LUGGAGES (
    luggage_id INT PRIMARY KEY AUTO_INCREMENT,
    ticket_id INT,
    luggage_type_id INT,
    quantity INT NOT NULL,
    FOREIGN KEY (ticket_id) REFERENCES TICKETS(ticket_id),
    FOREIGN KEY (luggage_type_id) REFERENCES LUGGAGES_TYPES(luggage_type_id)
);


-- DB POPULATION
-- Insertar países
INSERT INTO COUNTRIES (iso_code, name, is_active) VALUES
('CO', 'Colombia', 1),
('US', 'Estados Unidos', 1),
('BR', 'Brasil', 1),
('MX', 'México', 1),
('AR', 'Argentina', 1),
('ES', 'España', 1),
('FR', 'Francia', 1),
('DE', 'Alemania', 1),
('IT', 'Italia', 1),
('JP', 'Japón', 1);

-- Insertar tipos de documento
INSERT INTO DOCUMENT_TYPES (type_code, name, description, is_active) VALUES
('CC', 'Cédula de Ciudadanía', 'Documento de identidad colombiano', 1),
('TI', 'Tarjeta de Identidad', 'Documento para menores de edad', 1),
('PP', 'Pasaporte', 'Documento de identificación internacional', 1);

-- Insertar roles
INSERT INTO ROLES (code, name, description) VALUES
('PILOT', 'Piloto', 'Piloto de avión'),
('COPILOT', 'Copiloto', 'Asistente del piloto'),
('FLIGHT_ATTENDANT', 'Azafata', 'Tripulante de cabina'),
('AUXILIARY', 'Auxiliar', 'Auxiliar de vuelo'),
('ADMIN', 'Administrador', 'Administrador del sistema'),
('CUSTOMER', 'Cliente', 'Cliente de la aerolínea');

-- Insertar estados de contratos
INSERT INTO CONTRACTS_STATUSES (type_code, name, description, is_active) VALUES
('ACTIVE', 'Activo', 'Contrato en vigor', 1),
('INACTIVE', 'Inactivo', 'Contrato finalizado', 0);

-- Insertar estados de aviones
INSERT INTO AIRPLANES_STATUSES (status_code, status_name, status_description, is_active) VALUES
('AVAILABLE', 'Disponible', 'Avión operativo', 1),
('MAINTENANCE', 'En Mantenimiento', 'Avión en revisión', 1);

-- Insertar estados de vuelos
INSERT INTO FLIGHT_STATUSES (status_code, status_name, status_description, is_active) VALUES
('SCHEDULED', 'Programado', 'Vuelo pendiente de salida', 1),
('IN_PROGRESS', 'En Curso', 'Vuelo en el aire', 1),
('COMPLETED', 'Finalizado', 'Vuelo aterrizado', 1),
('CANCELLED', 'Cancelado', 'Vuelo no realizado', 1);

-- Insertar estados de tiquetes
INSERT INTO TICKET_STATUSES (status_code, status_name, status_description, is_active) VALUES
('PAID', 'Pagado', 'Tiquete pagado', 1),
('PENDING', 'Pendiente de Pago', 'Tiquete no pagado', 1);

-- Insertar tipos de equipajes
INSERT INTO LUGGAGES_TYPES (type_code, name, description, is_active) VALUES
('HAND', 'De Mano', 'Equipaje de mano', 1),
('10KG', '10kg', 'Equipaje mediano', 1),
('20KG', '20kg', 'Equipaje grande', 1);

-- Insertar ciudades
INSERT INTO CITIES (name, is_active) VALUES
('Medellín', 1), ('Bogotá', 1), ('Barranquilla', 1), ('San Andrés', 1);

-- Insertar usuarios (clientes y empleados)
INSERT INTO USERS (user_id, document_type_id, country_id, role_id, email, first_name, first_last_name, phone_number, address, birth_date, username, password_hash, is_active, created_at)
VALUES
(1, 1, 1, 1, 'admin@airline.com', 'Admin', 'Root', '3000000001', 'Admin Street', '1980-01-01', 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(2, 1, 1, 2, 'pilot1@airline.com', 'John', 'Pilot', '3000000002', 'Pilot Base', '1985-02-02', 'pilot1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(3, 1, 1, 3, 'attendant1@airline.com', 'Mary', 'Attendant', '3000000003', 'Attendant Base', '1990-03-03', 'attendant1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(4, 1, 1, 4, 'mechanic1@airline.com', 'Bob', 'Mechanic', '3000000004', 'Hangar 1', '1988-04-04', 'mechanic1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(5, 1, 1, 5, 'manager1@airline.com', 'Alice', 'Manager', '3000000005', 'Office 1', '1975-05-05', 'manager1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(6, 1, 1, 6, 'customer1@airline.com', 'Carlos', 'Customer', '3000000006', 'Customer Ave', '1995-06-06', 'customer1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW()),
(7, 1, 1, 6, 'customer2@airline.com', 'Laura', 'Customer', '3000000007', 'Customer Blvd', '1992-07-07', 'customer2', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, NOW());

-- Insertar aviones
INSERT INTO AIRPLANES (registration_number, airplane_status_id, passenger_capacity, manufacturer, model, acquisition_date) VALUES
('HK123', 1, 180, 'Boeing', '737', '2015-06-15'),
('HK456', 2, 200, 'Airbus', 'A320', '2018-09-10'),
('HK789', 1, 220, 'Boeing', '747', '2020-01-20'),
('HK321', 1, 150, 'Embraer', 'E190', '2017-05-30'),
('HK654', 1, 180, 'Boeing', '737 MAX', '2021-07-10');

-- Insertar más rutas y vuelos
INSERT INTO ROUTES (origin_city_id, destination_city_id) VALUES
(1, 2), (2, 3), (3, 4), (4, 1), (1, 3), (2, 4), (3, 1), (4, 2);

-- Insertar escalas
INSERT INTO LAYOVERS (route_id, city_id, stop_order, scheduled_arrival_time, scheduled_departure_time, layover_duration) VALUES
(1, 3, 1, '2025-06-15 10:00:00', '2025-06-15 11:00:00', '01:00:00'),
(2, 4, 1, '2025-06-16 12:00:00', '2025-06-16 13:00:00', '01:00:00'),
(3, 2, 1, '2025-06-17 14:00:00', '2025-06-17 15:00:00', '01:00:00'),
(4, 1, 1, '2025-06-18 08:00:00', '2025-06-18 09:00:00', '01:00:00');

-- Insertar vuelos
INSERT INTO FLIGHTS (airplane_id, route_id, flight_status_id, departure_time, arrival_time) VALUES
('HK123', 1, 1, '2025-06-15 08:00:00', '2025-06-15 12:00:00'),
('HK789', 2, 1, '2025-06-16 09:30:00', '2025-06-16 14:00:00');

-- Insertar más tiquetes y equipajes
INSERT INTO TICKETS (customer_id, flight_id, ticket_status_id, price, assigned_seat, sale_date) VALUES
(4, 1, 1, 250.00, '12A', NOW()),
(5, 2, 2, 300.00, '15B', NOW()),
(6, 1, 1, 280.00, '10C', NOW());

INSERT INTO LUGGAGES (ticket_id, luggage_type_id, quantity) VALUES
(1, 1, 1), (1, 2, 1), (2, 3, 2), (3, 1, 1), (3, 3, 1);

-- Asignar empleados a vuelos
INSERT INTO EMPLOYEES_FLIGHTS (employee_id, flight_id) VALUES
(1, 1), (2, 1), (3, 1), (7, 1), (1, 2), (2, 2), (3, 2), (7, 2);

/* 
-- Borrar datos
-- Eliminar registros de tablas que dependen de otras
DELETE FROM EMPLOYEES_FLIGHTS;
DELETE FROM LUGGAGES;
DELETE FROM TICKETS;
DELETE FROM FLIGHTS;
DELETE FROM LAYOVERS;
DELETE FROM ROUTES;
DELETE FROM AIRPLANES;

DELETE FROM AIRPLANES_STATUSES;
DELETE FROM FLIGHT_STATUSES;
DELETE FROM TICKET_STATUSES;
DELETE FROM CITIES;
DELETE FROM LUGGAGES_TYPES;

DELETE FROM USERS;

DELETE FROM ROLES;
DELETE FROM DOCUMENT_TYPES;
DELETE FROM COUNTRIES;
DELETE FROM CONTRACTS_STATUSES;

-- Primero las tablas con relaciones dependientes
DROP TABLE IF EXISTS EMPLOYEES_FLIGHTS;
DROP TABLE IF EXISTS LUGGAGES;
DROP TABLE IF EXISTS TICKETS;
DROP TABLE IF EXISTS FLIGHTS;
DROP TABLE IF EXISTS LAYOVERS;
DROP TABLE IF EXISTS ROUTES;
DROP TABLE IF EXISTS AIRPLANES;

-- Luego las tablas intermedias
DROP TABLE IF EXISTS AIRPLANES_STATUSES;
DROP TABLE IF EXISTS FLIGHT_STATUSES;
DROP TABLE IF EXISTS TICKET_STATUSES;
DROP TABLE IF EXISTS CITIES;
DROP TABLE IF EXISTS LUGGAGES_TYPES;

-- Finalmente las tablas principales
DROP TABLE IF EXISTS USERS;
DROP TABLE IF EXISTS ROLES;
DROP TABLE IF EXISTS DOCUMENT_TYPES;
DROP TABLE IF EXISTS COUNTRIES;
DROP TABLE IF EXISTS CONTRACTS_STATUSES;
*/

