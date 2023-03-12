Emir Zecic , Task: TirepressureMonitoringSystem

Problems:
1) Alarm class has fixed range values, which should be moved into other ConfigurationClass. Values can be stored in ConfigurationClass, or get data from exteranla source, like file or DB
2) Tight coupling problem in Alarm class. Alarm class depeneds on Signal class. It violets the "O" of SOLID pricipels. Abstraction should be implemented. In the task solution an Interface ISensor was exctracted from Sensor class.
 
<ul dir="auto">
<li><a href="https://www.programmierer-gesucht.com" rel="nofollow">Express Digital Solutions</a> —
<a href="https://www.programmierer-gesucht.com" rel="nofollow">programmierer - freelancer finden</a>
,
<a href="https://github.com/emir506/RefactorMircoExcercise">github</a>

</li>
</ul>
 
