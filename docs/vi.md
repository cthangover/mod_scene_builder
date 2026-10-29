# Trình dựng cảnh — cảnh Godot của mod với xem trước trực tiếp

Trình dựng cảnh sửa các cảnh Godot của mod (`.tscn`: bảng, phần HUD, băng rôn) ngay trên màn hình trò chơi đang chạy. Bạn thấy cảnh ở đúng chỗ nó sẽ xuất hiện, kéo các nút của nó, đổi thuộc tính trong bảng thuộc tính, và tệp được ghi lại mà không mất những phần trình dựng không hiển thị.

## Cách mở

Nút búa trên thanh công cụ trong trò chơi → **Trình dựng cảnh**.

## Sửa một cảnh

1. Danh sách đầu tiên là cảnh nền mà cảnh của mod hiển thị lên trên (hoặc cảnh trống).
2. **Mod** và **Cảnh của mod (.tscn)** — tệp cần sửa.
3. Chọn nút bằng cách bấm vào nó trong bản xem trước hoặc trong **Phân cấp**. Màu vàng là gốc của cảnh mod, nút sáng sửa được, nút mờ thuộc cảnh nền và chỉ đọc.
4. Kéo nút bằng thân hoặc tay nắm, hoặc đổi thuộc tính trong **Thuộc tính** (số, chữ, màu, công tắc, vị trí). Thay đổi trong bảng thuộc tính và bằng tay nắm tự lưu.
5. Thêm nút loại đã chọn vào nút đang chọn, hoặc xóa nút đang chọn cùng các con của nó (Del).
6. Thẻ **Mã nguồn .tscn** hiện văn bản; sửa tay được lưu bằng Ctrl+S, đồng thời dựng lại bản xem trước. **Tải lại từ đĩa** bỏ các thay đổi chưa lưu.

Trong tệp chỉ những giá trị đã đổi được ghi lại; tài nguyên, kết nối và thuộc tính mà bảng thuộc tính không biết vẫn giữ nguyên.

## Giới hạn

- Chỉ mod dạng thư mục; không lưu được mod đóng gói ("mod chỉ đọc").
- Các nút của cảnh nền chỉ hiển thị để định hướng và không bao giờ được ghi.

## Phụ thuộc

`tools_base`, `ui_base`.
Gói cũ `editor_tools` cài mod này cùng các cửa sổ tác giả khác.
