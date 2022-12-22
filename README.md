# **Дневник трейдера**
Данное *приложение* создано для трейдеров. 
*Основной функционал* заключается в 
+ возможности *ведения учёта сделок* с возможностью редактирования
+ *формировании статистики* с возможностью выбора периода и активов
## **Установка**
Для установки и работы с приложением достаточно запустить файл *TraderDiary/bin/Debug/TraderDiary.exe*
## **Использование**
### **Главное окно**
![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/First.png)

На главном окне мы можем выбрать два варианта:

**1. Выбрать файл**
- Файл должен иметь формат .txt и быть пустым или соответствовать шаблону:
    * Токен (формата $token)
    * Дата (формата ддММММгг)
    * Тип позиции (Long/Short)
    * Количество лотов (число)
    * Цена входа (число)
    * Цена закрытия (число)
    * Комиссия (число)
    * Комментарий (по желанию)

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Second.png)
- В случае, если файл не соответствует шаблону, программа сообщит об этом и попросит выбрать другой. 
- В случае, если файл не выбран, переходим ко второму пункту

**2. Продолжить**
- Нажимая продолжить без выбора файла/отмены выбора, программа сообщит о том, что в таком случае будет выбран файл *TraderDairy.txt*, находящийся в корне проекта и запустит второе окно.
![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Third.png)

### Дневник
![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Fourth.png)

Транзакции в дневнике отсортированы по датам сделок. Столбец ROE высчитывается автоматически на основе введённых данных.
Дневник имеет четыре основных функции:

**1. Добавить файл**

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Fifth.png)

+ Чтобы добавить новую сделку необходимо ввести свои данные на основе примера, в случае, если одно из полей (кроме комментария) не заполнено - программа попросит заполнить его. 
+ Также, если поля заполнены неверно пользователь будет проинформирован. Например:

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Sixth.png)

+ После добавления новой сделки таблица автоматически отсортируется и рассчитается ROE.

**2. Изменить**

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Seventh.png)

+ При нажатии правой кнопки по *выделенной!* строке, откроется контекстное меню с возможностью изменить данные выбранной сделки. 
+ Окно изменения данных аналогично добавлению, за исключением того, что имеющиеся данные уже заполнены. 
+ Изменения происходят мгновенно.

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Eighth.png)

**3. Удалить**

+ При нажатии правой кнопки по *выделенной!* строке, откроется контекстное меню с возможностью удалить выбранную сделку.
+ Удаление происходит мгновенно.

**4. Статистика**

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Ninth.png)

Функция статистики - полезное дополнение к дневнику трейдера. С помощью неё мы можем получить отчёт о произведённых сделках за выбранный пользователем период и токен.

+ Список токенов формируется автоматически в комбобоксе. Пользователь может выбрать любой токен, либо все сразу.

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Tenth.png)

+ Осуществляется проверка правильного выбора диапозона дат.
+ Названия файла может быть введено пользователем самостоятельно.
+ В случае, если название файла пустое или соответсвует шаблону - происходит автоматическая генерация его названия.
+ В случае, если за указанный период сделок нет - пользователь получает сообщение

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Eleventh.png)

+ В случае, если за указанный период сделки есть - пользователь получает сообщение с указанным именем файла и папки, куда он сохраняется (/Отчёты).

![](https://github.com/AlexSkvorz/TraderDiary/blob/main/ScreensForREADME/Twelfth.png)

## **Сделано с помощью**
+ С#
+ WPF

## **Автор**
+ Telegram - [AlexSkvorz](https://t.me/AlexSkvorz)
+ VK - [AlexSkvorz](https://vk.com/alexskvorz)

## **Проект соответствует требованиям, указанным в файле "Правила для зачета ПИЭ-3 осень 2022.docx"**