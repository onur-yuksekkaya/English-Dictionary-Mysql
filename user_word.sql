-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 21 May 2019, 12:50:42
-- Sunucu sürümü: 10.1.39-MariaDB
-- PHP Sürümü: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `user_word`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `words_1`
--

CREATE TABLE `words_1` (
  `id` int(11) NOT NULL,
  `word_id` varchar(11) COLLATE utf8_turkish_ci DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `first_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `words_1`
--

INSERT INTO `words_1` (`id`, `word_id`, `level`, `first_date`) VALUES
(29, '473', 2, '2019-01-21'),
(30, '502', 2, '2019-03-21'),
(31, '2427', 3, '2019-05-20'),
(32, '1563', 6, '2019-05-20'),
(33, '257', 1, '2019-05-22'),
(34, '1027', 1, '2019-05-21'),
(35, '770', 5, '2019-05-21'),
(36, '2473', 4, '2019-05-21'),
(37, '129', 6, '2019-05-21'),
(38, '1687', 1, '2019-03-21'),
(39, '1196', 4, '2019-03-21'),
(40, '1221', 1, '2019-05-21'),
(41, '988', 2, '2019-05-21'),
(42, '153', 1, '2019-05-21'),
(43, '373', 1, '2019-02-21'),
(44, '672', 1, '2019-02-21'),
(45, '654', 1, '2019-05-21'),
(46, '2476', 1, '2019-05-21');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `words_2`
--

CREATE TABLE `words_2` (
  `id` int(11) NOT NULL,
  `word_id` varchar(11) COLLATE utf8_turkish_ci DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `first_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `words_2`
--

INSERT INTO `words_2` (`id`, `word_id`, `level`, `first_date`) VALUES
(2, '2010', 2, '2019-05-21'),
(3, '850', 2, '2019-05-21'),
(4, '1057', 1, '2019-05-21'),
(5, '804', 1, '2019-05-21'),
(6, '134', 2, '2019-05-20'),
(7, '520', 2, '2019-05-21'),
(8, '71', 2, '2019-05-21'),
(9, '1267', 2, '2019-05-21'),
(10, '2352', 2, '2019-05-21');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `words_3`
--

CREATE TABLE `words_3` (
  `id` int(11) NOT NULL,
  `word_id` varchar(11) COLLATE utf8_turkish_ci DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `first_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `words_5`
--

CREATE TABLE `words_5` (
  `id` int(11) NOT NULL,
  `word_id` varchar(11) COLLATE utf8_turkish_ci DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `first_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `words_6`
--

CREATE TABLE `words_6` (
  `id` int(11) NOT NULL,
  `word_id` varchar(11) COLLATE utf8_turkish_ci DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `first_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `words_1`
--
ALTER TABLE `words_1`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `words_2`
--
ALTER TABLE `words_2`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `words_3`
--
ALTER TABLE `words_3`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `words_5`
--
ALTER TABLE `words_5`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `words_6`
--
ALTER TABLE `words_6`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `words_1`
--
ALTER TABLE `words_1`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- Tablo için AUTO_INCREMENT değeri `words_2`
--
ALTER TABLE `words_2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `words_3`
--
ALTER TABLE `words_3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `words_5`
--
ALTER TABLE `words_5`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `words_6`
--
ALTER TABLE `words_6`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
