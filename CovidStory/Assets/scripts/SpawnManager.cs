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
        //a += 1f; revise

        if (b == -0.8f)
            positions[top++] = new Vector2(a, b);
        else
            positions2[top2++] = new Vector2(a, b);
    }
    void initialize_enemy(){
        {
            insert_Note(12.00131f, -0.8f);
            insert_Note(15.45224f, -0.8f);
            insert_Note(19.06003f, -0.8f);
            insert_Note(20.78549f, -0.8f);
            insert_Note(22.38583f, -0.8f);
            insert_Note(25.85422f, 2.3f);
            insert_Note(29.37455f, 2.3f);
            insert_Note(32.89749f, 2.3f);
            insert_Note(34.50644f, 2.3f);
            insert_Note(36.40853f, 2.3f);
            insert_Note(40.40887f, -0.8f);
            insert_Note(44.22279f, -0.8f);
            insert_Note(47.83058f, -0.8f);
            insert_Note(49.86977f, -0.8f);
            insert_Note(51.3101f, -0.8f);
            insert_Note(55.2495f, 2.3f);
            insert_Note(58.76983f, 2.3f);
            insert_Note(62.29277f, 2.3f);
            insert_Note(64.06172f, 2.3f);
            insert_Note(65.80957f, 2.3f);
            insert_Note(69.8495f, -0.8f);
            insert_Note(73.62724f, -0.8f);
            insert_Note(77.07816f, -0.8f);
            insert_Note(78.80363f, 2.3f);
            insert_Note(80.404f, -0.8f);
            insert_Note(84.18612f, -0.8f);
            insert_Note(88.26449f, -0.8f);
            insert_Note(92.02914f, -0.8f);
            insert_Note(93.59774f, 2.3f);
            insert_Note(95.19811f, -0.8f);
            insert_Note(98.82337f, -0.8f);
            insert_Note(103.0586f, -0.8f);
            insert_Note(106.6664f, -0.8f);
            insert_Note(108.0781f, 2.3f);
            insert_Note(109.8385f, -0.8f);
            insert_Note(113.9345f, -0.8f);
            insert_Note(118.0129f, -0.8f);
            insert_Note(121.7775f, -0.8f);
            insert_Note(123.0324f, 2.3f);
            insert_Note(124.9528f, -0.8f);
            insert_Note(128.2655f, 2.3f);
            insert_Note(132.426f, 2.3f);
            insert_Note(136.268f, 2.3f);
            insert_Note(138.0288f, -0.8f);
            insert_Note(139.9299f, 2.3f);
            insert_Note(143.2904f, 2.3f);
            insert_Note(147.2919f, 2.3f);
            insert_Note(150.8165f, 2.3f);
            insert_Note(152.9023f, -0.8f);
            insert_Note(154.5016f, 2.3f);
            insert_Note(158.182f, 2.3f);
            insert_Note(161.7074f, 2.3f);
            insert_Note(165.3966f, 2.3f);
            insert_Note(166.9977f, -0.8f);
            insert_Note(168.584f, 2.3f);
            insert_Note(172.7444f, 2.3f);
            insert_Note(176.7465f, 2.3f);
            insert_Note(179.9486f, 2.3f);
            insert_Note(181.8703f, -0.8f);
            insert_Note(183.6204f, 2.3f);
            insert_Note(186.8208f, -0.8f);
            insert_Note(190.9135f, -0.8f);
            insert_Note(194.5213f, -0.8f);
            insert_Note(196.7173f, 2.3f);
            insert_Note(197.9977f, -0.8f);
            insert_Note(201.3105f, 2.3f);
            insert_Note(205.4709f, 2.3f);
            insert_Note(208.993f, 2.3f);
            insert_Note(210.7585f, -0.8f);
            insert_Note(212.5056f, 2.3f);
            insert_Note(215.8661f, -0.8f);
            insert_Note(219.9596f, -0.8f);
            insert_Note(223.5674f, -0.8f);
            insert_Note(225.6065f, 2.3f);
            insert_Note(227.3669f, -0.8f);
            insert_Note(230.6786f, 2.3f);
            insert_Note(234.5191f, 2.3f);
            insert_Note(238.3676f, 2.3f);
            insert_Note(240.2901f, -0.8f);
            insert_Note(242.0368f, 2.3f);
            // currently completed here
            insert_Note(245.1314f, -0.8f);
            insert_Note(248.137f, -0.8f);
            insert_Note(251.2742f, 2.3f);
            insert_Note(260.523f, -0.8f);
            insert_Note(264.4445f, -0.8f);
            insert_Note(267.4248f, 2.3f);
            insert_Note(274.9672f, -0.8f);
            insert_Note(278.8887f, -0.8f);
            insert_Note(281.7122f, 2.3f);
            insert_Note(289.8819f, -0.8f);
            insert_Note(293.4897f, -0.8f);
            insert_Note(296.4701f, 2.3f);
            insert_Note(304.6398f, -0.8f);
            insert_Note(308.4045f, -0.8f);
            insert_Note(311.3848f, 2.3f);
            insert_Note(320.0252f, -0.8f);
            insert_Note(323.4761f, -0.8f);
            insert_Note(326.7702f, 2.3f);
            insert_Note(334.7831f, -0.8f);
            insert_Note(336.9791f, 2.3f);
            insert_Note(339.0595f, -0.8f);
            insert_Note(341.1194f, 2.3f);
            insert_Note(343.1997f, -0.8f);
            insert_Note(345.2596f, 2.3f);
            insert_Note(347.02f, -0.8f);
            insert_Note(348.6061f, 2.3f);
            insert_Note(350.5265f, -0.8f);
            insert_Note(353.0549f, 2.3f);
            insert_Note(355.2953f, -0.8f);
            insert_Note(357.2016f, 2.3f);
            insert_Note(359.282f, -0.8f);
            insert_Note(361.0281f, 2.3f);
            insert_Note(364.5485f, -0.8f);
            insert_Note(366.1357f, 2.3f);
            insert_Note(370.6161f, -0.8f);
            insert_Note(372.8252f, 2.3f);
            insert_Note(377.7856f, -0.8f);
            insert_Note(380.0292f, 2.3f);
            insert_Note(384.9897f, -0.8f);
            insert_Note(387.0764f, 2.3f);
            insert_Note(392.8933f, 2.3f);
            insert_Note(394.8137f, -0.8f);
            insert_Note(399.3813f, 2.3f);
            insert_Note(401.7816f, -0.8f);
            insert_Note(406.3595f, 2.3f);
            insert_Note(408.9199f, -0.8f);
            insert_Note(413.0338f, 2.3f);
            insert_Note(414.9542f, -0.8f);
            insert_Note(420.7766f, -0.8f);
            insert_Note(423.2864f, 2.3f);
            insert_Note(428.4758f, -0.8f);
            insert_Note(430.8287f, 2.3f);
            insert_Note(435.9492f, -0.8f);
            insert_Note(438.4689f, 2.3f);
            insert_Note(444.2857f, -0.8f);
            insert_Note(446.3249f, 2.3f);
            insert_Note(451.8281f, 2.3f);
            insert_Note(454.0685f, -0.8f);
            insert_Note(458.4846f, 2.3f);
            insert_Note(460.7249f, -0.8f);
            insert_Note(464.9842f, 2.3f);
            insert_Note(467.5446f, -0.8f);
            insert_Note(471.6585f, 2.3f);
            insert_Note(474.3789f, -0.8f);
            insert_Note(480.0703f, -0.8f);
            insert_Note(482.4232f, 2.3f);
            insert_Note(487.7694f, -0.8f);
            insert_Note(489.9655f, 2.3f);
            insert_Note(494.9259f, -0.8f);
            insert_Note(497.1696f, 2.3f);
            insert_Note(501.97f, -0.8f);
            insert_Note(504.5107f, 2.3f);
            insert_Note(510.1707f, 2.3f);
            insert_Note(512.411f, -0.8f);
            insert_Note(516.5134f, 2.3f);
            insert_Note(519.5532f, -0.8f);
            insert_Note(523.8043f, 2.3f);
            insert_Note(527.004f, -0.8f);
            insert_Note(530.6261f, 2.3f);
            insert_Note(533.9858f, -0.8f);
            insert_Note(538.3929f, -0.8f);
            insert_Note(541.2727f, 2.3f);
            insert_Note(545.4059f, -0.8f);
            insert_Note(548.9256f, 2.3f);
            insert_Note(553.0225f, -0.8f);
            insert_Note(556.2222f, 2.3f);
            insert_Note(560.158f, -0.8f);
            insert_Note(563.1978f, 2.3f);
            insert_Note(568.8606f, 2.3f);
            insert_Note(571.9978f, -0.8f);
            insert_Note(575.8375f, 2.3f);
            insert_Note(578.5394f, -0.8f);
            insert_Note(582.379f, 2.3f);
            insert_Note(585.5515f, -0.8f);
            insert_Note(589.7111f, 2.3f);
            insert_Note(593.3325f, -0.8f);
        }
        for (int i=0; i<top; i++){
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
