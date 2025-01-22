RenHong:
    1. 按鈕更改文字 ok
    2. 新增namespace，裡面為加減乘除, 按鈕傳值進去運算 再回傳，再更改文字 ok
    3. 執行序嘗試建兩個 ok
    4. 多表單視窗建立 ok
    5. 繪圖 ok
    6. 劃一個圓，可移動
    7. C# 讀DXF的"圓"要座標，要直徑，以及"點"要座標 (比較難) (優先)
    8. python傳2x100的浮點數陣列給C#                (比較難)
       C# call python，去拿資料
    1. 使用C#開啟RS232
    2. 可即時對RS232收發資料
    3. 基本文字資料處理: 尋找字元、尋找字串、字串切割、插入字串
    4. 建立dll
    5. 引用自己建立的dll
    6. pyQT(暫停)
    1. 會先提供一個71x71=5041個圓的DXF檔案，要做:
        1-1. 轉成Json檔，要包含: 
            1-1-A. 流水號
            1-1-B. 名稱
            1-1-C. 編號
            1-1-D. 座標
            1-1-E. 直徑
            1-1-F. 放置
            1-1-G. 移除
            1-1-H. 置換
            1-1-I. 顯示
            1-1-J. 啟用
            1-1-K. 保留1
            1-1-L. 保留2
            1-1-M. 保留3
            1-1-N. 保留4
            1-1-O. 保留5
        1-2. 依照Json檔，忠實畫出全部的圓
    1. ptQT Thread ok
    1. pyQT 開RS232 對傳 ok
    2. C# / pyQT / python 互傳資料 ok
    3. 研究 MOBUS-485 以及 MOBUS TCP ok
    4. 4點校正 ok
    1. 4點影像校正 轉C#語言 (ok)
    
[Xavier] 請幫忙研究:
    1. 軸空平台: tWinCat: 馬達設定, 找廠商來講解twinCAT
    2. FreeRTOS 找資料 看一看, VisualStudio的範例, (*****)
    3. STM 周邊練習: LED呼吸燈 (30%)
    4. Button,  => Button+LED Breath, Single Click(slow), Double Click(Normal), Tripple Click(duty), Long Press(LED Off),
                                      //-------------------------- 1s -----------------------------//------- 2s -------//
    5. STM I2C(EEPROM:24AA01/24LC01B, IOexpender:PCF8575), SPI(RTC:DS1302, Flash:W25Q128), 源達/祥倉
    6. IR收(https://hobbycomponents.com/opto-electronics/463-1838b-infrared-ir-receiver), 發(LED)
    7. UART, RCC中斷, Timer, (問AI), 485, 
    8. LCD1202, (Encoder:https://tw.element14.com/bourns/pec11r-4220k-s0024/incremental-encoder-12mm-60rpm/dp/2663528?CMP=KNC-GOO-SHOPPING-2663528&CMP=&mckv=sffAFc7Gw_dc|pcrid|191433825590|pkw||pmt||slid||product|2663528|pgrid|41608933397|ptaid|pla-300794752538|&gad_source=1&gclid=Cj0KCQiA4rK8BhD7ARIsAFe5LXK7NQobMvvaUc1caK6cGQBt-SK4wRwTyw2HhEwd_-PNWminJqgvuhQaAhPcEALw_wcB)

   0. UI完整
   1. 9點 16點 校正 (pending)
   2. Parallel port 開啟 與控制 (非常難, pending)
   3. Ethernet(lwip 野火板子) (XavierTsai)
   4. https://blog.csdn.net/zzz_xxj/article/details/119862465 (SOEM) (XavierTsai)
       
