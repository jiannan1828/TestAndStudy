import numpy as np
import cv2
import matplotlib.pyplot as plt

# 定義原始點（透視變形的四邊形）
src_points = np.array([
    [0, 0],   
    [500, 0],  
    [400, 500], 
    [100, 500]   
], dtype=np.float32)

# 定義目標點（校正後的正方形）
dst_points = np.array([
    [0, 0],     # 左上角
    [500, 0],   # 右上角
    [500, 500], # 右下角
    [0, 500]    # 左下角
], dtype=np.float32)

# 計算透視變換矩陣
H = cv2.getPerspectiveTransform(src_points, dst_points)

# 顯示變換矩陣
print("透視變換矩陣 H:")
print(H)

# 加載真實圖片
# 替換 "your_image.jpg" 為你的圖片文件路徑
image = cv2.imread(r"C:\Users\r417t\Desktop\2367645-XXL.jpg")
if image is None:
    raise ValueError("圖片加載失敗，請檢查文件路徑！")

# 應用透視變換
warped_image = cv2.warpPerspective(image, H, (500, 500))

# 顯示原始圖片和校正後的圖片
plt.figure(figsize=(12, 6))
plt.subplot(1, 2, 1)
plt.title("Original")
plt.imshow(image)
plt.subplot(1, 2, 2)
plt.title("Perspective Transform")
plt.imshow(warped_image)
plt.show()