import com.nervds.Run;
import com.nervds.mapper.CoursesMapper;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;


@RunWith(SpringJUnit4ClassRunner.class)
@SpringBootTest(classes = Run.class )//这里是启动类
public class Test {

    @Autowired
    private CoursesMapper coursesMapper;

    @org.junit.Test
    public void getTreeData(){
        System.out.println(coursesMapper.selectByExample("id","desc"));
    }
}
