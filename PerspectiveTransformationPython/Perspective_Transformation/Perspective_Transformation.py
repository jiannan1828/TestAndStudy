import numpy as np
import cv2
import matplotlib.pyplot as plt

# 定義原始點（透視變形的四邊形）
src_points = np.array([
    [100, 100],   
    [400, 100],  
    [300, 400], 
    [200, 400]   
], dtype=np.float32)

# 定義目標點（校正後的正方形）
dst_points = np.array([
    [100, 100],     # 左上角
    [400, 100],   # 右上角
    [400, 400], # 右下角
    [100, 400]    # 左下角
], dtype=np.float32)

# 計算透視變換矩陣
H = cv2.getPerspectiveTransform(src_points, dst_points)

# 顯示變換矩陣
print("透視變換矩陣 H:")
print(H)

# 假設有一張模擬圖片
image = np.zeros((500, 500, 3), dtype=np.uint8)
cv2.polylines(image, [src_points.astype(np.int32)], isClosed=True, color=(0, 255, 0), thickness=2)

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