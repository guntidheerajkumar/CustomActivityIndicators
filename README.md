# Custom Activity Indicators
Custom Activity Indicator View

This is a Obj-C Porting Project based on https://github.com/ninjaprox/NVActivityIndicatorView.

### Animation types

| Type |
|---|
1. BallPulse |
2. BallGridPulse| 
3. BallClipRotate |
4. SquareSpin|
5. BallClipRotatePulse |
6. BallClipRotateMultiple |
7. BallPulseRise |
8. BallRotate|
9. CubeTransition |
10. BallZigZag |
11. BallZigZagDeflect |
12. BallTrianglePath|
13. BallScale |
14. LineScale |
15. LineScaleParty |
16. BallScaleMultiple|
17. BallPulseSync |
18. BallBeat |
19. LineScalePulseOut |
20. LineScalePulseOutRapid|
21. BallScaleRipple |
22. BallScaleRippleMultiple |
23. BallSpinFadeLoader |
24. LineSpinFadeLoader|
25. TriangleSkewSpin |
26. Pacman |
27. BallGridBeat |
28. SemiCircleSpin|
29. BallRotateChase |
30. Orbit |
31. AudioEqualizer|

### Usage

```
DGActivityIndicatorView DView = new DGActivityIndicatorView(DGActivityIndicatorAnimationType.RotatingSandglass, UIColor.Blue, 20f);
DView.Frame = new CGRect(this.View.Bounds.Width / 2 - 25, this.View.Bounds.Height / 2 - 25, 50, 50);
this.View.AddSubview(DView);
DView.StartAnimating();
```
