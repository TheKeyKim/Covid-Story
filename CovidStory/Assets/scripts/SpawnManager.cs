using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnManager : MonoBehaviour 
{
    public GameObject enemy;
    public GameObject enemy2;
    Vector2[] positions = new Vector2[300];
    Vector2[] positions2 = new Vector2[300];
    int top = 0;
    int top2 = 0;

    public float bottom = -0.8f;
    public float ceiling = 2.3f;
    // Start is called before the first frame update

    void insert_Note(float a, float b){
        a += 1f; // revise
        if (b == -0.8f)
            positions[top++] = new Vector2(a, b);
        else
            positions2[top2++] = new Vector2(a, b);
    }
    void initialize_enemy(){
        {
            insert_Note(11.00131f, -0.8f);
            insert_Note(14.45224f, -0.8f);
            insert_Note(18.06003f, -0.8f);
            insert_Note(19.78549f, -0.8f);
            insert_Note(21.38583f, -0.8f);
            insert_Note(24.85422f, 2.3f);
            insert_Note(28.37455f, 2.3f);
            insert_Note(31.89749f, 2.3f);
            insert_Note(33.50644f, 2.3f);
            insert_Note(35.40853f, 2.3f);
            insert_Note(39.40887f, -0.8f);
            insert_Note(43.22279f, -0.8f);
            insert_Note(46.83058f, -0.8f);
            insert_Note(48.86977f, -0.8f);
            insert_Note(50.3101f, -0.8f);
            insert_Note(54.2495f, 2.3f);
            insert_Note(57.76983f, 2.3f);
            insert_Note(61.29277f, 2.3f);
            insert_Note(63.06172f, 2.3f);
            insert_Note(64.80957f, 2.3f);
            insert_Note(68.8495f, -0.8f);
            insert_Note(72.62724f, -0.8f);
            insert_Note(76.07816f, -0.8f);
            insert_Note(77.80363f, 2.3f);
            insert_Note(79.404f, -0.8f);
            insert_Note(83.18612f, -0.8f);
            insert_Note(87.26449f, -0.8f);
            insert_Note(91.02914f, -0.8f);
            insert_Note(92.59774f, 2.3f);
            insert_Note(94.19811f, -0.8f);
            insert_Note(97.82337f, -0.8f);
            insert_Note(102.0586f, -0.8f);
            insert_Note(105.6664f, -0.8f);
            insert_Note(107.0781f, 2.3f);
            insert_Note(108.8385f, -0.8f);
            insert_Note(112.9345f, -0.8f);
            insert_Note(117.0129f, -0.8f);
            insert_Note(120.7775f, -0.8f);
            insert_Note(122.0324f, 2.3f);
            insert_Note(123.9528f, -0.8f);
            insert_Note(127.2655f, 2.3f);
            insert_Note(131.426f, 2.3f);
            insert_Note(135.268f, 2.3f);
            insert_Note(137.0288f, -0.8f);
            insert_Note(138.9299f, 2.3f);
            insert_Note(142.2904f, 2.3f);
            insert_Note(146.2919f, 2.3f);
            insert_Note(149.8165f, 2.3f);
            insert_Note(151.9023f, -0.8f);
            insert_Note(153.5016f, 2.3f);
            insert_Note(157.182f, 2.3f);
            insert_Note(160.7074f, 2.3f);
            insert_Note(164.3966f, 2.3f);
            insert_Note(165.9977f, -0.8f);
            insert_Note(167.584f, 2.3f);
            insert_Note(171.7444f, 2.3f);
            insert_Note(175.7465f, 2.3f);
            insert_Note(178.9486f, 2.3f);
            insert_Note(180.8703f, -0.8f);
            insert_Note(182.6204f, 2.3f);
            insert_Note(185.8208f, -0.8f);
            insert_Note(189.9135f, -0.8f);
            insert_Note(193.5213f, -0.8f);
            insert_Note(195.7173f, 2.3f);
            insert_Note(196.9977f, -0.8f);
            insert_Note(200.3105f, 2.3f);
            insert_Note(204.4709f, 2.3f);
            insert_Note(207.993f, 2.3f);
            insert_Note(209.7585f, -0.8f);
            insert_Note(211.5056f, 2.3f);
            insert_Note(214.8661f, -0.8f);
            insert_Note(218.9596f, -0.8f);
            insert_Note(222.5674f, -0.8f);
            insert_Note(224.6065f, 2.3f);
            insert_Note(226.3669f, -0.8f);
            insert_Note(229.6786f, 2.3f);
            insert_Note(233.5191f, 2.3f);
            insert_Note(237.3676f, 2.3f);
            insert_Note(239.2901f, -0.8f);
            insert_Note(241.0368f, 2.3f);

            insert_Note(247.0744f, -0.8f);
            // currently completed here
            //insert_Note(248.0289f, -0.8f);
        insert_Note(250.8878f, 2.3f);
        insert_Note(253.2881f, -0.8f);
        insert_Note(254.8857f, 2.3f);
        insert_Note(258.2461f, -0.8f);
        insert_Note(262.1827f, -0.8f);
        insert_Note(266.2611f, -0.8f);
        insert_Note(268.7708f, -0.8f);
        insert_Note(270.4963f, -0.8f);
        insert_Note(272.0649f, -0.8f);
        insert_Note(273.9472f, 2.3f);
        insert_Note(277.3076f, -0.8f);
        insert_Note(280.3031f, 2.3f);
        insert_Note(282.8635f, -0.8f);
        insert_Note(284.6245f, 2.3f);
        insert_Note(288.1449f, -0.8f);
        insert_Note(291.4576f, 2.3f);
        insert_Note(294.818f, -0.8f);
        insert_Note(297.3429f, 2.3f);
        insert_Note(299.2632f, -0.8f);
        insert_Note(301.321f, 2.3f);
        insert_Note(305.3215f, -0.8f);
        insert_Note(307.4099f, 2.3f);
        insert_Note(309.4903f, -0.8f);
        insert_Note(312.4913f, 2.3f);
        insert_Note(314.8917f, -0.8f);
        insert_Note(318.0578f, 2.3f);
        insert_Note(320.1382f, -0.8f);
        insert_Note(323.296f, 2.3f);
        insert_Note(326.1764f, -0.8f);
        insert_Note(328.4273f, 2.3f);
        insert_Note(330.0277f, -0.8f);
        insert_Note(331.7706f, 2.3f);
        insert_Note(335.291f, -0.8f);
        insert_Note(338.6037f, 2.3f);
        insert_Note(341.9641f, -0.8f);
        insert_Note(345.2733f, 2.3f);
        insert_Note(348.1537f, -0.8f);
        insert_Note(350.2477f, 2.3f);
        insert_Note(351.8481f, -0.8f);
        insert_Note(353.9047f, 2.3f);
        insert_Note(355.5051f, -0.8f);
        insert_Note(357.248f, 2.3f);
        insert_Note(360.1284f, 2.3f);
        insert_Note(362.376f, -0.8f);
        insert_Note(364.1494f, 2.3f);
        insert_Note(367.1898f, 2.3f);
        insert_Note(370.5603f, 2.3f);
        insert_Note(373.4504f, 2.3f);
        insert_Note(376.8114f, 2.3f);
        insert_Note(379.6969f, 2.3f);
        insert_Note(381.2977f, 2.3f);
        insert_Note(383.8585f, 2.3f);
        insert_Note(385.789f, 2.3f);
        insert_Note(387.2324f, -0.8f);
        insert_Note(389.1338f, 2.3f);
        insert_Note(391.3741f, -0.8f);
        insert_Note(393.1236f, 2.3f);
        insert_Note(395.044f, -0.8f);
        insert_Note(398.0429f, -0.8f);
        insert_Note(400.0821f, -0.8f);
        insert_Note(402.435f, -0.8f);
        insert_Note(403.3762f, -0.8f);
        insert_Note(405.886f, -0.8f);
        insert_Note(406.984f, -0.8f);
        insert_Note(409.3369f, -0.8f);
        insert_Note(412.1604f, -0.8f);
        insert_Note(414.9839f, -0.8f);
        insert_Note(416.8662f, -0.8f);
        insert_Note(417.8073f, -0.8f);
        insert_Note(419.2191f, 2.3f);
        insert_Note(421.1395f, -0.8f);
        insert_Note(422.8835f, 2.3f);
        insert_Note(424.3239f, -0.8f);
        insert_Note(425.283f, 2.3f);
        insert_Note(427.5234f, -0.8f);
        insert_Note(428.9591f, 2.3f);
        insert_Note(431.3596f, -0.8f);
        insert_Note(432.4865f, 2.3f);
        insert_Note(433.1265f, 2.3f);
        insert_Note(435.0469f, -0.8f);
        insert_Note(437.4354f, 2.3f);
        insert_Note(439.0358f, -0.8f);
        insert_Note(442.0336f, 2.3f);
        insert_Note(443.954f, -0.8f);
        insert_Note(446.1686f, 2.3f);
        insert_Note(448.409f, -0.8f);
        insert_Note(450.4722f, 2.3f);
        insert_Note(452.3926f, -0.8f);
        insert_Note(453.8229f, 2.3f);
        insert_Note(457.8234f, -0.8f);
        insert_Note(459.7549f, 2.3f);
        insert_Note(463.5954f, -0.8f);
        insert_Note(465.1993f, 2.3f);
        insert_Note(467.7597f, -0.8f);
        insert_Note(470.6187f, 2.3f);
        insert_Note(472.2191f, -0.8f);
        insert_Note(474.5894f, 2.3f);
        insert_Note(477.7899f, -0.8f);
        insert_Note(479.5297f, 2.3f);
        insert_Note(481.1301f, -0.8f);
        insert_Note(482.0887f, 2.3f);
        insert_Note(484.8091f, -0.8f);
        insert_Note(487.2065f, 2.3f);
        insert_Note(488.9668f, -0.8f);
        insert_Note(491.9648f, 2.3f);
        insert_Note(494.6852f, -0.8f);
        insert_Note(496.6119f, 2.3f);
        insert_Note(499.1723f, -0.8f);
        insert_Note(501.4039f, 2.3f);
        insert_Note(503.0042f, -0.8f);
        insert_Note(504.1197f, 2.3f);
        insert_Note(506.3601f, -0.8f);
        insert_Note(508.1096f, 2.3f);
        insert_Note(509.87f, -0.8f);
        insert_Note(513.3385f, 2.3f);
        insert_Note(516.0587f, -0.8f);
        insert_Note(517.9852f, 2.3f);
        insert_Note(519.2653f, -0.8f);
        insert_Note(519.5852f, -0.8f);
        insert_Note(521.6368f, 2.3f);
        insert_Note(523.3968f, -0.8f);
        insert_Note(525.1398f, 2.3f);
        insert_Note(527.5397f, -0.8f);
        insert_Note(529.9214f, 2.3f);
        insert_Note(531.2015f, -0.8f);
        insert_Note(532.1613f, 2.3f);
        insert_Note(534.8811f, -0.8f);
        insert_Note(536.6508f, 2.3f);
        insert_Note(538.5708f, -0.8f);
        insert_Note(541.4128f, 2.3f);
        insert_Note(544.1327f, -0.8f);
        insert_Note(545.9023f, -0.8f);
        insert_Note(548.569f, 2.3f);
        insert_Note(551.1288f, -0.8f);
        insert_Note(553.2034f, 2.3f);
        insert_Note(554.4835f, -0.8f);
        insert_Note(557.3256f, 2.3f);
        insert_Note(559.2456f, -0.8f);
        insert_Note(560.6759f, 2.3f);
        insert_Note(562.9158f, -0.8f);
        insert_Note(565.1358f, 2.3f);
        insert_Note(566.8958f, -0.8f);
        insert_Note(568.0114f, 2.3f);
        insert_Note(570.0913f, -0.8f);
        insert_Note(571.21f, 2.3f);
        insert_Note(573.7699f, -0.8f);
        insert_Note(575.0602f, 2.3f);
        insert_Note(577.3001f, -0.8f);
        insert_Note(579.3632f, 2.3f);
        insert_Note(581.7631f, -0.8f);}
        for(int i=0; i<top; i++){
            Instantiate(enemy, positions[i], Quaternion.identity);
        }
        for(int j=0; j<top2; j++)
        {
            Instantiate(enemy2, positions2[j], Quaternion.identity);
        }
    }
    void Start()
    {
        initialize_enemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
