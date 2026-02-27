namespace ClinicDesk.Controls;

public class MaterialAnimations
{
    public enum AnimationRunType
    {
        Normal,
        Fast
    }

    internal enum AnimationType
    {
        Linear,
        EaseOut,
        EaseInOut,
        CustomQuadratic
    }

    internal enum AnimationDirection
    {
        In,
        Out,
        InOutIn,
        InOutOut,
        InOutRepeatingIn,
        InOutRepeatingOut
    }

    internal static class AnimationLinear
    {
        public static double CalculateProgress(double progress)
        {
            return progress;
        }
    }

    internal static class AnimationEaseInOut
    {
        public static double PI = Math.PI;

        public static double PI_HALF = Math.PI / 2.0;

        public static double CalculateProgress(double progress)
        {
            return EaseInOut(progress);
        }

        private static double EaseInOut(double s)
        {
            return s - Math.Sin(s * 2.0 * PI) / (2.0 * PI);
        }
    }

    public static class AnimationEaseOut
    {
        public static double CalculateProgress(double progress)
        {
            return -1.0 * progress * (progress - 2.0);
        }
    }

    public static class AnimationCustomQuadratic
    {
        public static double CalculateProgress(double progress)
        {
            double num = 0.6;
            return 1.0 - Math.Cos((Math.Max(progress, num) - num) * Math.PI / (2.0 - 2.0 * num));
        }
    }

    internal class AnimationManager
    {
        public delegate void AnimationFinished(object sender);

        public delegate void AnimationProgress(object sender);

        private readonly List<double> _animationProgresses;

        private readonly List<Point> _animationSources;

        private readonly List<AnimationDirection> _animationDirections;

        private readonly List<object[]> _animationDatas;

        private const double MIN_VALUE = 0.0;

        private const double MAX_VALUE = 1.0;

        private readonly System.Windows.Forms.Timer _animationTimer = new System.Windows.Forms.Timer
        {
            Interval = 5,
            Enabled = false
        };

        public bool InterruptAnimation { get; set; }

        public double Increment { get; set; }

        public double SecondaryIncrement { get; set; }

        public AnimationType AnimationType { get; set; }

        public bool Singular { get; set; }

        public event AnimationFinished OnAnimationFinished;

        public event AnimationProgress OnAnimationProgress;

        public AnimationManager(bool singular = true)
        {
            _animationProgresses = new List<double>();
            _animationSources = new List<Point>();
            _animationDirections = new List<AnimationDirection>();
            _animationDatas = new List<object[]>();
            Increment = 0.03;
            SecondaryIncrement = 0.03;
            AnimationType = AnimationType.Linear;
            InterruptAnimation = true;
            Singular = singular;
            if (Singular)
            {
                _animationProgresses.Add(0.0);
                _animationSources.Add(new Point(0, 0));
                _animationDirections.Add(AnimationDirection.In);
            }

            _animationTimer.Tick += AnimationTimerOnTick;
        }

        private void AnimationTimerOnTick(object sender, EventArgs eventArgs)
        {
            try
            {
                if (AnimationRun == AnimationRunType.Fast)
                {
                    Parallel.For(0, _animationProgresses.Count, delegate (int i)
                    {
                        UpdateProgress(i);
                        if (!Singular)
                        {
                            if (_animationDirections[i] == AnimationDirection.InOutIn && _animationProgresses[i] == 1.0)
                            {
                                _animationDirections[i] = AnimationDirection.InOutOut;
                            }
                            else if (_animationDirections[i] == AnimationDirection.InOutRepeatingIn && _animationProgresses[i] == 0.0)
                            {
                                _animationDirections[i] = AnimationDirection.InOutRepeatingOut;
                            }
                            else if (_animationDirections[i] == AnimationDirection.InOutRepeatingOut && _animationProgresses[i] == 0.0)
                            {
                                _animationDirections[i] = AnimationDirection.InOutRepeatingIn;
                            }
                            else if ((_animationDirections[i] == AnimationDirection.In && _animationProgresses[i] == 1.0) || (_animationDirections[i] == AnimationDirection.Out && _animationProgresses[i] == 0.0) || (_animationDirections[i] == AnimationDirection.InOutOut && _animationProgresses[i] == 0.0))
                            {
                                _animationProgresses.RemoveAt(i);
                                _animationSources.RemoveAt(i);
                                _animationDirections.RemoveAt(i);
                                _animationDatas.RemoveAt(i);
                            }
                        }
                        else if (_animationDirections[i] == AnimationDirection.InOutIn && _animationProgresses[i] == 1.0)
                        {
                            _animationDirections[i] = AnimationDirection.InOutOut;
                        }
                        else if (_animationDirections[i] == AnimationDirection.InOutRepeatingIn && _animationProgresses[i] == 1.0)
                        {
                            _animationDirections[i] = AnimationDirection.InOutRepeatingOut;
                        }
                        else if (_animationDirections[i] == AnimationDirection.InOutRepeatingOut && _animationProgresses[i] == 0.0)
                        {
                            _animationDirections[i] = AnimationDirection.InOutRepeatingIn;
                        }
                    });
                }
                else
                {
                    for (int num = 0; num < _animationProgresses.Count; num++)
                    {
                        UpdateProgress(num);
                        if (!Singular)
                        {
                            if (_animationDirections[num] == AnimationDirection.InOutIn && _animationProgresses[num] == 1.0)
                            {
                                _animationDirections[num] = AnimationDirection.InOutOut;
                            }
                            else if (_animationDirections[num] == AnimationDirection.InOutRepeatingIn && _animationProgresses[num] == 0.0)
                            {
                                _animationDirections[num] = AnimationDirection.InOutRepeatingOut;
                            }
                            else if (_animationDirections[num] == AnimationDirection.InOutRepeatingOut && _animationProgresses[num] == 0.0)
                            {
                                _animationDirections[num] = AnimationDirection.InOutRepeatingIn;
                            }
                            else if ((_animationDirections[num] == AnimationDirection.In && _animationProgresses[num] == 1.0) || (_animationDirections[num] == AnimationDirection.Out && _animationProgresses[num] == 0.0) || (_animationDirections[num] == AnimationDirection.InOutOut && _animationProgresses[num] == 0.0))
                            {
                                _animationProgresses.RemoveAt(num);
                                _animationSources.RemoveAt(num);
                                _animationDirections.RemoveAt(num);
                                _animationDatas.RemoveAt(num);
                            }
                        }
                        else if (_animationDirections[num] == AnimationDirection.InOutIn && _animationProgresses[num] == 1.0)
                        {
                            _animationDirections[num] = AnimationDirection.InOutOut;
                        }
                        else if (_animationDirections[num] == AnimationDirection.InOutRepeatingIn && _animationProgresses[num] == 1.0)
                        {
                            _animationDirections[num] = AnimationDirection.InOutRepeatingOut;
                        }
                        else if (_animationDirections[num] == AnimationDirection.InOutRepeatingOut && _animationProgresses[num] == 0.0)
                        {
                            _animationDirections[num] = AnimationDirection.InOutRepeatingIn;
                        }
                    }
                }

                this.OnAnimationProgress?.Invoke(this);
            }
            catch
            {
            }
        }

        public bool IsAnimating()
        {
            return _animationTimer.Enabled;
        }

        public void StartNewAnimation(AnimationDirection animationDirection, object[] data = null)
        {
            StartNewAnimation(animationDirection, new Point(0, 0), data);
        }

        public void StartNewAnimation(AnimationDirection animationDirection, Point animationSource, object[] data = null)
        {
            if (!IsAnimating() || InterruptAnimation)
            {
                if (Singular && _animationDirections.Count > 0)
                {
                    _animationDirections[0] = animationDirection;
                }
                else
                {
                    _animationDirections.Add(animationDirection);
                }

                if (Singular && _animationSources.Count > 0)
                {
                    _animationSources[0] = animationSource;
                }
                else
                {
                    _animationSources.Add(animationSource);
                }

                if (!Singular || _animationProgresses.Count <= 0)
                {
                    switch (_animationDirections[_animationDirections.Count - 1])
                    {
                        case AnimationDirection.In:
                        case AnimationDirection.InOutIn:
                        case AnimationDirection.InOutRepeatingIn:
                            _animationProgresses.Add(0.0);
                            break;
                        case AnimationDirection.Out:
                        case AnimationDirection.InOutOut:
                        case AnimationDirection.InOutRepeatingOut:
                            _animationProgresses.Add(1.0);
                            break;
                        default:
                            throw new Exception("Invalid AnimationDirection");
                    }
                }

                if (Singular && _animationDatas.Count > 0)
                {
                    _animationDatas[0] = data ?? new object[0];
                }
                else
                {
                    _animationDatas.Add(data ?? new object[0]);
                }
            }

            _animationTimer.Start();
        }

        public void UpdateProgress(int index)
        {
            switch (_animationDirections[index])
            {
                case AnimationDirection.In:
                case AnimationDirection.InOutIn:
                case AnimationDirection.InOutRepeatingIn:
                    IncrementProgress(index);
                    break;
                case AnimationDirection.Out:
                case AnimationDirection.InOutOut:
                case AnimationDirection.InOutRepeatingOut:
                    DecrementProgress(index);
                    break;
                default:
                    throw new Exception("No AnimationDirection has been set");
            }
        }

        private void IncrementProgress(int index)
        {
            try
            {
                _animationProgresses[index] += Increment;
                if (!(_animationProgresses[index] > 1.0))
                {
                    return;
                }

                _animationProgresses[index] = 1.0;
                if (AnimationRun == AnimationRunType.Fast)
                {
                    Parallel.For(0, GetAnimationCount(), delegate (int i)
                    {
                        if (_animationDirections[i] != AnimationDirection.InOutIn && _animationDirections[i] != AnimationDirection.InOutRepeatingIn && _animationDirections[i] != AnimationDirection.InOutRepeatingOut && (_animationDirections[i] != AnimationDirection.InOutOut || _animationProgresses[i] == 1.0) && _animationDirections[i] == AnimationDirection.In)
                        {
                            _ = _animationProgresses[i];
                            _ = 1.0;
                        }
                    });
                }
                else
                {
                    for (int num = 0; num < GetAnimationCount(); num++)
                    {
                        if (_animationDirections[num] == AnimationDirection.InOutIn || _animationDirections[num] == AnimationDirection.InOutRepeatingIn || _animationDirections[num] == AnimationDirection.InOutRepeatingOut || (_animationDirections[num] == AnimationDirection.InOutOut && _animationProgresses[num] != 1.0) || (_animationDirections[num] == AnimationDirection.In && _animationProgresses[num] != 1.0))
                        {
                            return;
                        }
                    }
                }

                _animationTimer.Stop();
                this.OnAnimationFinished?.Invoke(this);
            }
            catch
            {
            }
        }

        private void DecrementProgress(int index)
        {
            try
            {
                List<double> animationProgresses = _animationProgresses;
                List<double> list = animationProgresses;
                double num = animationProgresses[index];
                AnimationDirection animationDirection = _animationDirections[index];
                bool flag = ((animationDirection == AnimationDirection.InOutOut || animationDirection == AnimationDirection.InOutRepeatingOut) ? true : false);
                list[index] = num - (flag ? SecondaryIncrement : Increment);
                if (!(_animationProgresses[index] < 0.0))
                {
                    return;
                }

                _animationProgresses[index] = 0.0;
                if (AnimationRun == AnimationRunType.Fast)
                {
                    Parallel.For(0, GetAnimationCount(), delegate (int i)
                    {
                        if (_animationDirections[i] != AnimationDirection.InOutIn && _animationDirections[i] != AnimationDirection.InOutRepeatingIn && _animationDirections[i] != AnimationDirection.InOutRepeatingOut && (_animationDirections[i] != AnimationDirection.InOutOut || _animationProgresses[i] == 0.0) && _animationDirections[i] == AnimationDirection.Out)
                        {
                            _ = _animationProgresses[i];
                            _ = 0.0;
                        }
                    });
                }
                else
                {
                    for (int num2 = 0; num2 < GetAnimationCount(); num2++)
                    {
                        if (_animationDirections[num2] == AnimationDirection.InOutIn || _animationDirections[num2] == AnimationDirection.InOutRepeatingIn || _animationDirections[num2] == AnimationDirection.InOutRepeatingOut || (_animationDirections[num2] == AnimationDirection.InOutOut && _animationProgresses[num2] != 0.0) || (_animationDirections[num2] == AnimationDirection.Out && _animationProgresses[num2] != 0.0))
                        {
                            return;
                        }
                    }
                }

                _animationTimer.Stop();
                this.OnAnimationFinished?.Invoke(this);
            }
            catch
            {
            }
        }

        public double GetProgress()
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            return GetProgress(0);
        }

        public double GetProgress(int index)
        {
            if (index >= GetAnimationCount())
            {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return AnimationType switch
            {
                AnimationType.Linear => AnimationLinear.CalculateProgress(_animationProgresses[index]),
                AnimationType.EaseInOut => AnimationEaseInOut.CalculateProgress(_animationProgresses[index]),
                AnimationType.EaseOut => AnimationEaseOut.CalculateProgress(_animationProgresses[index]),
                AnimationType.CustomQuadratic => AnimationCustomQuadratic.CalculateProgress(_animationProgresses[index]),
                _ => throw new NotImplementedException("The given AnimationType is not implemented"),
            };
        }

        public Point GetSource(int index)
        {
            if (index >= GetAnimationCount())
            {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationSources[index];
        }

        public Point GetSource()
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationSources.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            return _animationSources[0];
        }

        public AnimationDirection GetDirection()
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDirections.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            return _animationDirections[0];
        }

        public AnimationDirection GetDirection(int index)
        {
            if (index >= _animationDirections.Count)
            {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationDirections[index];
        }

        public object[] GetData()
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDatas.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            return _animationDatas[0];
        }

        public object[] GetData(int index)
        {
            if (index >= _animationDatas.Count)
            {
                throw new IndexOutOfRangeException("Invalid animation index");
            }

            return _animationDatas[index];
        }

        public int GetAnimationCount()
        {
            return _animationProgresses.Count;
        }

        public void SetProgress(double progress)
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            _animationProgresses[0] = progress;
        }

        public void SetDirection(AnimationDirection direction)
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationProgresses.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            _animationDirections[0] = direction;
        }

        public void SetData(object[] data)
        {
            if (!Singular)
            {
                throw new Exception("Animation is not set to Singular.");
            }

            if (_animationDatas.Count == 0)
            {
                throw new Exception("Invalid animation");
            }

            _animationDatas[0] = data;
        }
    }

    public static AnimationRunType AnimationRun { get; set; }
}