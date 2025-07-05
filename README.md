# WinForms-ThucHanh-Template
Repository mẫu cho các bài thực hành môn Lập trình Windows Forms C#

# **Bài Thực Hành Môn Lập Trình Windows Forms C#**

Chào mừng các bạn đến với môn học Lập trình Windows Forms. Repository này là nơi các bạn sẽ lưu trữ và nộp tất cả các bài thực hành trong suốt 9 tuần học.

## **QUY TẮC BẮT BUỘC**

Mỗi sinh viên **BẮT BUỘC** phải tuân thủ các quy tắc sau để được chấm điểm:

1.  **Tạo Repository của riêng bạn:** Sử dụng repository này làm MẪU (template).
2.  **Đặt tên Repository:** `[MSSV]-[HoTen]` (Ví dụ: `2001210123-NguyenVanA`).
3.  **Nộp bài đúng cấu trúc:** Mỗi tuần sẽ có một thư mục tương ứng (`Tuan01`, `Tuan02`...). Project Visual Studio của tuần nào phải nằm **TRỌN VẸN** trong thư mục của tuần đó.
4.  **Commit thường xuyên:** Thực hiện commit sau mỗi lần hoàn thành một chức năng quan trọng với nội dung commit rõ ràng.

---

## **HƯỚNG DẪN THIẾT LẬP (CHỈ LÀM 1 LẦN DUY NHẤT)**

#### **Bước 1: Tạo Repository cá nhân từ mẫu này**
1.  Nhấn vào nút màu xanh lá **Use this template** > **Create a new repository** ở góc trên bên phải.
2.  **Owner:** Chọn tài khoản GitHub của bạn.
3.  **Repository name:** Đặt tên theo đúng quy tắc: `[MSSV]-[HoTen]`.
4.  **Description:** Giữ nguyên hoặc thêm mô tả của riêng bạn.
5.  Chọn **Public**.
6.  Nhấn **Create repository**.

#### **Bước 2: Clone repository về máy tính của bạn**
1.  Vào trang repository bạn vừa tạo.
2.  Nhấn nút màu xanh lá **<> Code**.
3.  Copy đường link HTTPS (ví dụ: `https://github.com/your-username/[MSSV]-[HoTen].git`).
4.  Mở Git Bash hoặc Terminal trên máy tính, di chuyển đến thư mục bạn muốn lưu bài tập và gõ lệnh:
    ```bash
    git clone [đường-link-bạn-vừa-copy]
    ```

---

## **QUY TRÌNH LÀM BÀI HÀNG TUẦN (LẶP LẠI 9 LẦN)**

Giả sử bạn đang làm bài thực hành cho **Tuần 1**.

#### **Bước 1: Tạo Project Visual Studio đúng vị trí**
1.  Mở thư mục repository đã clone về máy (ví dụ: `D:\2001210123-NguyenVanA`).
2.  Đi vào thư mục của tuần tương ứng, ví dụ: `Tuan01`.
3.  Mở Visual Studio, tạo một Project Windows Forms mới và ở bước **Configure your project**, mục **Location**, hãy trỏ đường dẫn đến thư mục của tuần đó (ví dụ: `D:\...\Tuan01`).

#### **Bước 2: Làm bài và Commit**
1.  Thực hiện các yêu cầu của bài thực hành.
2.  Sau khi làm xong một yêu cầu, hãy mở Git Bash/Terminal và thực hiện các lệnh sau:
    ```bash
    # Thêm tất cả các thay đổi vào Git
    git add .

    # "Đóng gói" các thay đổi với một thông điệp rõ ràng
    git commit -m "Tuan01: Hoan thanh chuc nang Them, Xoa, Sua"

    # Đẩy các thay đổi lên GitHub
    git push
    ```
**Mẹo:** Hãy tập thói quen `commit` với thông điệp có ý nghĩa. Ví dụ:
* `git commit -m "Tuan01: Thiet ke giao dien form Quan Ly Sinh Vien"`
* `git commit -m "Tuan01: Them chuc nang ket noi CSDL"`

#### **Bước 3: Nộp bài**
Giảng viên sẽ chấm bài trực tiếp trên repository GitHub của bạn vào cuối mỗi tuần. Bạn chỉ cần đảm bảo đã `push` code mới nhất lên trước hạn chót.
