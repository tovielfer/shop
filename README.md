# shop2
# shop2# תיאור הפרויקט
# shop2
# תיאור הפרויקט
## ישויות
- ספק
- עובד
- מוצר
## לספק ROUTES  מיפוי
 - שליפת רשימת ספקים 
GET https://localhost:7035/api/Provider
- שליפת ספק לפי מזהה
 GET https://localhost:7275/api/Provider/1
- הוספת ספק
POST  https://localhost:7275/api/Provider
- עדכון ספק
PUT https://localhost:7275/api/Provider/1
- מחיקת ספק
DELETE https://localhost:7275/api/Provider/1
##  עובד ROUTES  מיפוי
 - שליפת רשימת עובדים
GET https://localhost:7275/api/Employee
- שליפת עובד לפי מזהה
 GET   https://localhost:7275/api/Employee/1
- הוספת עובד
POST  https://localhost:7275/api/Employee
- עדכון עובד
PUT  https://localhost:7275/api/Employee/1
- מחיקת עובד
DELETE   https://localhost:7275/api/Employee/1
##   מוצר ROUTES  מיפוי
 - שליפת רשימת מוצרים
GET https://localhost:7275/api/Product
- שליפת מוצר  לפי מזהה
 GET   https://localhost:7275/api/Product/1
- הוספת מוצר
POST  https://localhost:7275/api/Product
- עדכון מוצר
PUT https://localhost:7275/api/Product/1
- מחיקת מוצר
DELETE   https://localhost:7275/api/Product/1
