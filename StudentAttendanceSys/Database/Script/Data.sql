-- إضافة البيانات إلى جدول الأقسام (tbl_Department)
INSERT INTO "tbl_Department" ("Department_ID", "Department_Name") VALUES
(1, N'علوم الحاسوب'),
(2, N'نظم المعلومات الإدارية'),
(3, N'الأمن السيبراني'),
(4, N'الذكاء الاصطناعي'),
(5, N'هندسة البرمجيات');

-- إضافة البيانات إلى جدول المستخدمين (tbl_Users)
INSERT INTO "tbl_Users" ("User_ID", "User_Type", "User_Name", "User_Password", "User_Full_Name", "User_Telphone", "User_Email") VALUES
(101, N'Admin', N'admin_manager', N'admin_pass_123', N'المدير العام للنظام', '0501234567', 'admin@university.edu'),
(102, N'Doctor', N'dr_ahmed', N'doc_pass_ahmed', N'د. أحمد عبدالله', '0502345678', 'a.abdullah@university.edu'),
(103, N'Doctor', N'dr_fatima', N'doc_pass_fatima', N'د. فاطمة محمد', '0503456789', 'f.mohammed@university.edu'),
(104, N'Doctor', N'dr_yousef', N'doc_pass_yousef', N'د. يوسف خالد', '0504567890', 'y.khaled@university.edu'),
(105, N'Doctor', N'dr_sara', N'doc_pass_sara', N'د. سارة علي', '0505678901', 's.ali@university.edu'),
(106, N'Doctor', N'dr_hassan', N'doc_pass_hassan', N'د. حسن محمود', '0506789012', 'h.mahmoud@university.edu'),
(107, N'Doctor', N'dr_noura', N'doc_pass_noura', N'د. نورة سالم', '0507890123', 'n.salem@university.edu'),
(108, N'Doctor', N'dr_omar', N'doc_pass_omar', N'د. عمر إبراهيم', '0508901234', 'o.ibrahim@university.edu'),
(109, N'Doctor', N'dr_layla', N'doc_pass_layla', N'د. ليلى فيصل', '0509012345', 'l.faisal@university.edu'),
(110, N'Doctor', N'dr_majed', N'doc_pass_majed', N'د. ماجد عبدالعزيز', '0510123456', 'm.aziz@university.edu'),
(111, N'Doctor', N'dr_amal', N'doc_pass_amal', N'د. أمل منصور', '0511234567', 'a.mansour@university.edu'),
(112, N'Doctor', N'dr_fahad', N'doc_pass_fahad', N'د. فهد سليمان', '0512345678', 'f.sulaiman@university.edu'),
(113, N'Doctor', N'dr_hind', N'doc_pass_hind', N'د. هند تركي', '0513456789', 'h.turki@university.edu'),
(114, N'Doctor', N'dr_saud', N'doc_pass_saud', N'د. سعود حمد', '0514567890', 's.hamad@university.edu'),
(115, N'Doctor', N'dr_ghada', N'doc_pass_ghada', N'د. غادة ناصر', '0515678901', 'g.nasser@university.edu'),
(116, N'Admin', N'support_admin', N'support_pass', N'مسؤول الدعم الفني', '0516789012', 'support@university.edu');

-- إضافة البيانات إلى جدول الطلاب (tbl_Student)
INSERT INTO "tbl_Student" ("Student_ID", "Student_Name", "Department_ID") VALUES
(201, N'خالد الفيصل', 1),
(202, N'نورة الحمد', 2),
(203, N'عبدالرحمن صالح', 3),
(204, N'سارة عبدالله', 4),
(205, N'محمد فهد', 5),
(206, N'ريم خالد', 1),
(207, N'فيصل سعود', 2),
(208, N'أمل ناصر', 3),
(209, N'علي حسن', 4),
(210, N'فاطمة أحمد', 5),
(211, N'سلطان وليد', 1),
(212, N'جنى تركي', 2),
(213, N'منصور علي', 3),
(214, N'شهد ماجد', 4),
(215, N'عبدالعزيز عمر', 5),
(216, N'لمى إبراهيم', 1);

-- إضافة البيانات إلى جدول المقررات (tbl_Course)
INSERT INTO "tbl_Course" ("Course_ID", "Course_Name", "Course_code", "User_ID") VALUES
(301, N'مقدمة في البرمجة بلغة بايثون', N'CS101', 102),
(302, N'قواعد البيانات المتقدمة', N'MIS202', 103),
(303, N'أمن الشبكات والمعلومات', N'SEC301', 104),
(304, N'أساسيات الذكاء الاصطناعي', N'AI210', 105),
(305, N'هندسة متطلبات البرمجيات', N'SE220', 106),
(306, N'هياكل البيانات', N'CS201', 107),
(307, N'تحليل وتصميم النظم', N'MIS310', 108),
(308, N'الاختراق الأخلاقي', N'SEC401', 109),
(309, N'تعلم الآلة', N'AI320', 110),
(310, N'أنماط التصميم', N'SE330', 111),
(311, N'البرمجة الشيئية', N'CS102', 102),
(312, N'إدارة مشاريع تقنية المعلومات', N'MIS420', 103),
(313, N'التشفير وأمن البيانات', N'SEC315', 104),
(314, N'معالجة اللغات الطبيعية', N'AI430', 105),
(315, N'اختبار البرمجيات وضمان الجودة', N'SE440', 106),
(316, N'الشبكات العصبونية', N'AI450', 110);

-- ربط الطلاب بالمقررات (tbl_Student_Course)
INSERT INTO "tbl_Student_Course" ("Student_ID", "Course_ID") VALUES
(201, 301), (201, 306), (202, 302), (202, 307), (203, 303), (203, 308),
(204, 304), (204, 309), (205, 305), (205, 310), (206, 301), (206, 311),
(207, 302), (208, 303), (209, 304), (210, 305), (211, 306), (212, 307),
(213, 308), (214, 309), (215, 310), (216, 311);

-- ربط أعضاء هيئة التدريس بالأقسام (tbl_Faculty_department)
INSERT INTO "tbl_Faculty_department" ("User_ID", "Department_ID") VALUES
(102, 1), (103, 2), (104, 3), (105, 4), (106, 5), (107, 1), (108, 2),
(109, 3), (110, 4), (111, 5), (112, 1), (113, 2), (114, 3), (115, 4),
(102, 5), (104, 1);

-- ربط المقررات بالأقسام (tbl_Course_Department)
INSERT INTO "tbl_Course_Department" ("Course_ID", "Department_ID") VALUES
(301, 1), (302, 2), (303, 3), (304, 4), (305, 5), (306, 1), (307, 2),
(308, 3), (309, 4), (310, 5), (311, 1), (312, 2), (313, 3), (314, 4),
(315, 5), (316, 4), (301, 5);


-- إضافة البيانات إلى جدول المحاضرات (tbl_lectures)
INSERT INTO "tbl_lectures" ("Lecture_ID", "Lecture_number", "Course_ID", "Date") VALUES
(401, 1, 301, '2025-09-08 08:00:00'),
(402, 2, 301, '2025-09-10 08:00:00'),
(403, 1, 302, '2025-09-08 10:00:00'),
(404, 2, 302, '2025-09-10 10:00:00'),
(405, 1, 303, '2025-09-09 09:00:00'),
(406, 2, 303, '2025-09-11 09:00:00'),
(407, 1, 304, '2025-09-09 11:00:00'),
(408, 2, 304, '2025-09-11 11:00:00'),
(409, 1, 305, '2025-09-09 13:00:00'),
(410, 2, 305, '2025-09-11 13:00:00'),
(411, 3, 301, '2025-09-15 08:00:00'),
(412, 3, 302, '2025-09-15 10:00:00'),
(413, 1, 306, '2025-09-16 12:00:00'),
(414, 1, 307, '2025-09-16 14:00:00'),
(415, 1, 308, '2025-09-17 09:00:00'),
(416, 1, 309, '2025-09-17 11:00:00');

-- إضافة البيانات إلى جدول الحضور (tbl_Attendance)
INSERT INTO "tbl_Attendance" ("Attendance_ID", "Lecture_ID", "Student_ID", "Status", "Notes") VALUES
(501, 401, 201, N'حاضر', NULL),
(502, 401, 206, N'غائب', N'عذر طبي'),
(503, 401, 211, N'حاضر', NULL),
(504, 402, 201, N'حاضر', N'وصل متأخراً 5 دقائق'),
(505, 402, 206, N'حاضر', NULL),
(506, 402, 211, N'غائب', NULL),
(507, 403, 202, N'حاضر', NULL),
(508, 403, 207, N'حاضر', NULL),
(509, 403, 212, N'حاضر', NULL),
(510, 404, 202, N'غائب', N'ظرف عائلي'),
(511, 404, 207, N'حاضر', NULL),
(512, 405, 203, N'حاضر', NULL),
(513, 405, 208, N'حاضر', NULL),
(514, 405, 213, N'غائب', NULL),
(515, 407, 204, N'حاضر', NULL),
(516, 407, 209, N'حاضر', NULL),
(517, 409, 205, N'حاضر', NULL);