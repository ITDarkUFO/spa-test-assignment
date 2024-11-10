import { Typography, Flex, Button } from 'antd';
import { ReloadOutlined } from '@ant-design/icons';

import { useDataFetch } from '../context/DataFetchContext';

const { Title, Paragraph } = Typography;

const ErrorPage = ({ error }) => {
    const { dispatch } = useDataFetch();

    const onClick = () => {
        dispatch({ type: 'TOGGLE_FETCH' });
    };

    return (
        <Flex vertical justify="center" align="center">
            <Title>Возникла ошибка при загрузке товаров</Title>
            <Paragraph style={{ fontSize: 20 }}>{error}</Paragraph>
            <Button type="primary" size="large" icon={<ReloadOutlined />} onClick={onClick}>Обновить страницу</Button>
        </Flex>
    );
};

export default ErrorPage;