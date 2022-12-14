# AutoPowerModeSwitcher
APMS aims to optimize heavy workload/gaming performance on poorly cooled systems such as old laptops by automatically switching power mode and stopping background tasks. This project was one of my first projects and developed it back when I was in high school! Because of this, please, do not expect it to be perfect.

Full feature set:
*Written in C#
*APMS can detect which processes are running and can automatically switch between the "CPU frequency limited" power plan to the balanced one, depending on the processes that are running. The process list can be configured.
*Comes with a handy menu that can be opened by right-clicking the taskbar icon. From that menu, you can quickly change power plans or access settings.
*Can be configured to lower max CPU frequency to an arbitrary value by creating a power plan and setting custom power plan GUID.
*Comes with an additional utility, AutoPowerSwitcher (APS), that allows you to schedule a shutdown/hibernate timer.
*Can be set to launch at startup.

###Screenshots:
# Screenshots of the UI
Main interface
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/AutoPowerModeSwitcher/main/repoimages/0.png)

Expanded interface
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/AutoPowerModeSwitcher/main/repoimages/1.png)

Settings
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/AutoPowerModeSwitcher/main/repoimages/2.png)

Taskbar menu
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/AutoPowerModeSwitcher/main/repoimages/3.png)

AutoPowerSwitcher
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/AutoPowerModeSwitcher/main/repoimages/4.png)
