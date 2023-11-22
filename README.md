# shop2
# shop2# תיאור הפרויקט
# shop2
# תיאור הפרויקט
## ישויות
- ספק
- הזמנה
- מוצר
## לספק ROUTES  מיפוי
 - שליפת רשימת ספקים 
GET https://localhost:7035/api/Provider
- שליפת ספק לפי מזהה
 GET https://localhost:7035/api/Provider/1
- הוספת ספק
POST  https://localhost:7035/api/Provider
- עדכון ספק
PUT https://localhost:7035/api/Provider/1
- מחיקת ספק
DELETE https://localhost:7035/api/Provider/1
##  הזמנה ROUTES  מיפוי
 - שליפת רשימת הזמנות
GET https://localhost:7035/api/Order
- שליפת הזמנה לפי מזהה
 GET   https://localhost:7035/api/Order/1
- הוספת הזמנה
POST  https://localhost:7035/api/Order
- עדכון הזמנה
PUT  https://localhost:7035/api/Order/1
- מחיקת הזמנה
DELETE   https://localhost:7035/api/Order/1
##   מוצר ROUTES  מיפוי
 - שליפת רשימת מוצרים
GET https://localhost:7035/api/Product
- שליפת מוצר  לפי מזהה
 GET   https://localhost:7035/api/Product/1
- הוספת מוצר
POST  https://localhost:7035/api/Product
- עדכון מחיר מוצר
PUT https://localhost:7035/api/Product/1/Price
- מחיקת מוצר
DELETE   https://localhost:7035/api/Product/1

-עדכון מוצר
https://localhost:7035/api/Product/1
