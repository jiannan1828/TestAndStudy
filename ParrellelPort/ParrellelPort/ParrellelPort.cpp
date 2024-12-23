#include <iostream>
#include <windows.h>

using namespace std;

int main() {
    // 打開並行端口，這裡用 LPT1（0x378）
    HANDLE hPort = CreateFile("\\\\.\\LPT1", GENERIC_WRITE, 0, NULL, OPEN_EXISTING, 0, NULL);

    if (hPort == INVALID_HANDLE_VALUE) {
        cout << "無法開啟並行端口。" << endl;
        return 1;
    }

    // 準備要寫入的數據（例如，將數據 0xFF 寫入端口）
    BYTE data = 0xFF;  // 這裡將 0xFF 寫入並行端口的數據線

    DWORD bytesWritten;
    BOOL result = WriteFile(hPort, &data, sizeof(data), &bytesWritten, NULL);

    if (result) {
        cout << "成功寫入數據。" << endl;
    }
    else {
        cout << "寫入失敗。" << endl;
    }

    // 關閉端口
    CloseHandle(hPort);
    return 0;
}