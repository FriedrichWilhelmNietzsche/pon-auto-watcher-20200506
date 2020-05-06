# pon-auto-watcher-20200506

![监测过程](https://github.com/FriedrichWilhelmNietzsche/pon-auto-watcher-20200506/blob/master/123124.gif)


1、状态介绍：

光开关：
<AD01_S_01>，通道一， 表示GPON
<AD01_S_02>, 通道二， 表示EPON

FOH-100：

无VOA:
不完全统计，GPON --> EPON 显示切换状态成功约25s；EPON --> GPON 显示切换状态成功约30s.
[15:05:01.835]发→◇sys state
[15:05:01.842]收←◆
sys_power_flg = 1
gpon_epon_change_flg = 1
mcu_temperate = 44.52
battary_volatge = 3.93
vbus_volatge = 4.34
Tmode_1490_dBm = 0.00
fan_speed_test = 10785
gpon_epon_display_flg = 1    //EPON


sys_power_flg = 1
gpon_epon_change_flg = 0
mcu_temperate = 44.12
battary_volatge = 3.89
vbus_volatge = 4.33
Tmode_1490_dBm = 0.00
fan_speed_test = 10905
gpon_epon_display_flg = 0   //GPON


有VOA:
不完全统计，GPON --> EPON 显示切换状态成功约18s；EPON --> GPON 显示切换状态成功约22s.
命令如下：
[15:06:58.795]收←◆
sys_power_flg = 1
gpon_epon_change_flg = 1
mcu_temperate = 53.24
battary_volatge = 3.82
vbus_volatge = 4.58
Tmode_1490_dBm = 0.00
fan_speed_test = 11985
gpon_epon_display_flg = 1   //EPON


sys_power_flg = 1
gpon_epon_change_flg = 0
mcu_temperate = 52.85
battary_volatge = 3.82
vbus_volatge = 4.54
Tmode_1490_dBm = 0.00
fan_speed_test = 11880
gpon_epon_display_flg = 0
gpon_GTC_sync_flg:1
epon_MPCP_message_flg:0   //GPON


1、分为自动测试，和非自动测试


1）非自动测试：按钮触发切换光开关，读取FOH-100状态，与光开关作比较，即FOH-100状态与光开关相同时停止，设置timeout = 10 min  （未添加）

2）自动测试：设置光开关切换周期，实时监控。
	t1为第一次切换所需时间（即：读取FOH-100状态与光开关作比较，当状态与光开关相同时所需时间，设置timeout = 10 min），Period(s)为设定的切换周期
	当Period(s)<t1时,令Period(s)=t1,读取FOH-100状态，即：需要 1 次来读取FOH-100状态
	当Period(s)>t1时,继续以2s为间隔读取FOH-100的状态,即：需要 1 + Math.Floor(( Period(s) - t1 ) / 2 )次来读取FOH-100状态

	一个周期：
	os send 1
	F1/F2 send
	os f1/f2 get and compare   = 0？
	if os f1/f2 same
	for( Math.Floor(( Period(s) - t1 ) / 2 ))
	os f1/f2 get and compare
	=0 1+gr++ 
	≠0 1+gw++
	

	os send 2
	F1/F2 send
	os f1/f2 get and compare
	if os f1/f2 same
	for( Math.Floor(( Period(s) - t1 ) / 2 ))
	os f1/f2 get and compare
