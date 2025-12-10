-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Hôte : db:3306
-- Généré le : mer. 29 oct. 2025 à 11:14
-- Version du serveur : 8.1.0
-- Version de PHP : 8.2.27

-- D'abord, supprimer la base si elle existe, puis la créer, puis créer les tables.

DROP DATABASE IF EXISTS `gsb-2`;
CREATE DATABASE IF NOT EXISTS `gsb-2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `gsb-2`;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

-- Suppression préalable des tables si elles existent, pour éviter les erreurs à la création
DROP TABLE IF EXISTS `Appartient`;
DROP TABLE IF EXISTS `Prescription`;
DROP TABLE IF EXISTS `Patient`;
DROP TABLE IF EXISTS `Medicine`;
DROP TABLE IF EXISTS `User`;

-- Création de la table User
CREATE TABLE `User` (
  `id_user` int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `firstname` varchar(50) DEFAULT NULL,
  `role` tinyint(1) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Création de la table Medicine
CREATE TABLE `Medicine` (
  `id_medicine` int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `id_user` int DEFAULT NULL,
  `dosage` varchar(100) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `description` text,
  `molecule` varchar(100) DEFAULT NULL,
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Création de la table Patient
CREATE TABLE `Patient` (
  `id_patient` int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `id_user` int DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `age` int DEFAULT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Création de la table Prescription
CREATE TABLE `Prescription` (
  `id_prescription` int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `id_user` int NOT NULL,
  `id_patient` int NOT NULL,
  `validity` date NOT NULL,
  KEY `id_user` (`id_user`),
  KEY `id_patient` (`id_patient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Création de la table Appartient
CREATE TABLE `Appartient` (
  `id_prescription` int DEFAULT NULL,
  `id_medicine` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  KEY `id_prescription` (`id_prescription`),
  KEY `id_medicine` (`id_medicine`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Ajout des contraintes de clés étrangères
ALTER TABLE `Appartient`
  ADD CONSTRAINT `Appartient_ibfk_1` FOREIGN KEY (`id_prescription`) REFERENCES `Prescription` (`id_prescription`) ON DELETE CASCADE,
  ADD CONSTRAINT `Appartient_ibfk_2` FOREIGN KEY (`id_medicine`) REFERENCES `Medicine` (`id_medicine`);

ALTER TABLE `Medicine`
  ADD CONSTRAINT `Medicine_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`);

ALTER TABLE `Patient`
  ADD CONSTRAINT `Patient_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`);

ALTER TABLE `Prescription`
  ADD CONSTRAINT `Prescription_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`),
  ADD CONSTRAINT `Prescription_ibfk_2` FOREIGN KEY (`id_patient`) REFERENCES `Patient` (`id_patient`);

-- Insertion des données dans User
INSERT INTO `User` (`id_user`, `firstname`, `role`, `name`, `email`, `password`) VALUES
(1, 'Laboratoire', 0, 'Labo', 'labo@gsb.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
(2, 'Docteur', 1, 'Doc', 'doc@gsb.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');

-- Insertion des données dans Medicine
INSERT INTO `Medicine` (`id_medicine`, `id_user`, `dosage`, `name`, `description`, `molecule`) VALUES
(1, 1, '1000mg', 'Doliprane', 'Antalgique et antipyrétique indiqué en cas de douleur et de fièvre.', 'Paracétamol'),
(2, 1, '500mg', 'Amoxicilline', 'Antibiotique de la famille des bêta-lactamines.', 'Amoxicilline'),
(3, 1, '3g', 'Smecta', 'Traitement symptomatique de la diarrhée aiguë.', 'Diosmectite'),
(4, 1, '80mg', 'Spasfon', 'Traitement symptomatique des douleurs liées aux troubles fonctionnels du tube digestif.', 'Phloroglucinol'),
(5, 1, '2mg', 'Imodium', 'Traitement symptomatique des diarrhées aiguës et chroniques.', 'Lopéramide'),
(6, 1, '400mg', 'Advil', 'Anti-inflammatoire non stéroïdien (AINS).', 'Ibuprofène'),
(7, 1, '20mg', 'Mopral', 'Inhibiteur de la pompe à protons.', 'Oméprazole'),
(8, 1, '10mg', 'Zyrtec', 'Antihistaminique pour le traitement des rhinites allergiques.', 'Cétirizine'),
(9, 1, '0.5mg', 'Xanax', 'Anxiolytique de la famille des benzodiazépines.', 'Alprazolam'),
(10, 1, '100mg', 'Levothyrox', 'Hormone thyroïdienne de synthèse.', 'Lévothyroxine');

-- Insertion des données dans Patient
INSERT INTO `Patient` (`id_patient`, `id_user`, `name`, `age`, `firstname`, `gender`) VALUES
(1, 2, 'Dupont', 45, 'Jean', 'H'),
(2, 2, 'Martin', 32, 'Sophie', 'F'),
(3, 2, 'Bernard', 67, 'Michel', 'H'),
(4, 2, 'Dubois', 28, 'Marie', 'F'),
(5, 2, 'Thomas', 12, 'Lucas', 'H');

-- Insertion des données dans Prescription
INSERT INTO `Prescription` (`id_prescription`, `id_user`, `id_patient`, `validity`) VALUES
(1, 2, 1, '2025-12-31'),
(2, 2, 2, '2025-11-15'),
(3, 2, 3, '2026-01-20');

-- Insertion des données dans Appartient
INSERT INTO `Appartient` (`id_prescription`, `id_medicine`, `quantity`) VALUES
(1, 1, 2), -- Doliprane pour Prescription 1
(1, 4, 1), -- Spasfon pour Prescription 1
(2, 2, 1), -- Amoxicilline pour Prescription 2
(3, 3, 1), -- Smecta pour Prescription 3
(3, 5, 2); -- Imodium pour Prescription 3

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
